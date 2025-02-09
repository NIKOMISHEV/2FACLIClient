﻿using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using TwoFA.Encryption;

namespace TwoFA.Tests;

[TestClass]
public class AesDataProtectorTests
{
    private static readonly string _testvalue = "Hello world!";
    private static readonly string _testpassword = "Sup3rS3cr3t!^";

    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void AesDataProtector_ThrowsOnNullOptions()
        => new AesDataProtector(null!);

    [TestMethod]
    public async Task EncryptDecrypt_Defaults()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions
        {
            // Default values
            HashAlgorithm = "SHA256",
            Iterations = 500000,
            CipherMode = CipherMode.CBC,
            PaddingMode = PaddingMode.PKCS7,
            SaltLength = 16,
            KeyLength = 32
        }));

        var testfile = GetTestFileName();

        // Encrypt and save value
        await target.SaveEncryptedAsync(testfile, _testvalue, _testpassword).ConfigureAwait(false);
        // Load and decrypt value
        var result = await target.LoadEncryptedAsync(testfile, _testpassword).ConfigureAwait(false);

        Assert.AreEqual(_testvalue, result);
    }

    [TestMethod]
    public async Task EncryptDecrypt_NonDefaults()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions
        {
            // Default values
            HashAlgorithm = "SHA384",
            Iterations = 1234567,
            CipherMode = CipherMode.CFB,
            PaddingMode = PaddingMode.ANSIX923,
            SaltLength = 32,
            KeyLength = 16
        }));

        var testfile = GetTestFileName();

        // Encrypt and save value
        await target.SaveEncryptedAsync(testfile, _testvalue, _testpassword).ConfigureAwait(false);
        // Load and decrypt value
        var result = await target.LoadEncryptedAsync(testfile, _testpassword).ConfigureAwait(false);

        Assert.AreEqual(_testvalue, result);
    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public async Task ThrowsOnInvalidVaultHeader()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions()));
        await target.LoadEncryptedAsync("data/invalidvaultheader.dat", string.Empty).ConfigureAwait(false);
    }

    [TestMethod]
    [ExpectedException(typeof(NotSupportedException))]
    public async Task ThrowsOnInvalidVaultVersion()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions()));
        await target.LoadEncryptedAsync("data/invalidvaultversion.dat", string.Empty).ConfigureAwait(false);
    }

    [TestMethod]
    [ExpectedException(typeof(CryptographicException))]
    public async Task ThrowsOnInvalidVaultData()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions()));
        await target.LoadEncryptedAsync("data/invalidvaultdata.dat", _testpassword).ConfigureAwait(false);
    }

    [TestMethod]
    [ExpectedException(typeof(CryptographicException))]
    public async Task ThrowsOnInvalidPassword()
    {
        var target = new AesDataProtector(Options.Create(new AesDataProtectorOptions()));
        var testfile = GetTestFileName();

        // Encrypt and save value
        await target.SaveEncryptedAsync(testfile, _testvalue, _testpassword).ConfigureAwait(false);
        // Load and decrypt value with incorrect password
        await target.LoadEncryptedAsync(testfile, "otherpassword").ConfigureAwait(false);
    }

    private static string GetTestFileName([CallerMemberName] string? name = null)
        => Path.Combine(Path.GetTempPath(), $"{(name ?? throw new ArgumentNullException(nameof(name))).ToLowerInvariant()}.dat");
}