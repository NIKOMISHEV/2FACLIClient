﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TwoFA.ResourceFiles {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Translations {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Translations() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TwoFA.ResourceFiles.Translations", typeof(Translations).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Lists accounts and matching TOTP codes.
        /// </summary>
        internal static string CMD_LIST {
            get {
                return ResourceManager.GetString("CMD_LIST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Download (refresh) TOTP password vault.
        /// </summary>
        internal static string CMD_REFRESH {
            get {
                return ResourceManager.GetString("CMD_REFRESH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LastPass 2FA CLI authenticator.
        /// </summary>
        internal static string CMD_ROOT {
            get {
                return ResourceManager.GetString("CMD_ROOT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to decrypt MFA backup.
        /// </summary>
        internal static string EX_DECRYPT_MFA_BACKUP_FAILED {
            get {
                return ResourceManager.GetString("EX_DECRYPT_MFA_BACKUP_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to initialize hash algorithm &apos;{0}&apos;.
        /// </summary>
        internal static string EX_FAILED_TO_INITIALIZE_HASHALGO {
            get {
                return ResourceManager.GetString("EX_FAILED_TO_INITIALIZE_HASHALGO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to retrieve iterations.
        /// </summary>
        internal static string EX_FAILED_TO_RETRIEVE_ITERATIONS {
            get {
                return ResourceManager.GetString("EX_FAILED_TO_RETRIEVE_ITERATIONS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hashalgorithm {0} not supported.
        /// </summary>
        internal static string EX_HASHALGORITHM_NOT_SUPPORTED {
            get {
                return ResourceManager.GetString("EX_HASHALGORITHM_NOT_SUPPORTED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incompatible vault version {0}, expected version {1}.
        /// </summary>
        internal static string EX_INCOMPATIBLE_VAULT_VERSION {
            get {
                return ResourceManager.GetString("EX_INCOMPATIBLE_VAULT_VERSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Login failed.
        /// </summary>
        internal static string EX_LOGIN_FAILED {
            get {
                return ResourceManager.GetString("EX_LOGIN_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to download MFA backup.
        /// </summary>
        internal static string EX_MFA_BACKUP_DOWNLOAD_FAILED {
            get {
                return ResourceManager.GetString("EX_MFA_BACKUP_DOWNLOAD_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unhandled exception: {0}.
        /// </summary>
        internal static string EX_UNHANDLED {
            get {
                return ResourceManager.GetString("EX_UNHANDLED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to decrypt vault.
        /// </summary>
        internal static string EX_VAULT_DECRYPTION_FAILED {
            get {
                return ResourceManager.GetString("EX_VAULT_DECRYPTION_FAILED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Vault file does not appear to be valid.
        /// </summary>
        internal static string EX_VAULT_FILE_INVALID {
            get {
                return ResourceManager.GetString("EX_VAULT_FILE_INVALID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Search string.
        /// </summary>
        internal static string OPT_FIND {
            get {
                return ResourceManager.GetString("OPT_FIND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current OTP code.
        /// </summary>
        internal static string OPT_OTP {
            get {
                return ResourceManager.GetString("OPT_OTP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Show secret (Warning: use at own risk!).
        /// </summary>
        internal static string OPT_SHOWSECRET {
            get {
                return ResourceManager.GetString("OPT_SHOWSECRET", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Username (emailaddress).
        /// </summary>
        internal static string OPT_USERNAME {
            get {
                return ResourceManager.GetString("OPT_USERNAME", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TOTP vault file.
        /// </summary>
        internal static string OPT_VAULT_FILE {
            get {
                return ResourceManager.GetString("OPT_VAULT_FILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Verbose.
        /// </summary>
        internal static string OPT_VERBOSE {
            get {
                return ResourceManager.GetString("OPT_VERBOSE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm local vault password.
        /// </summary>
        internal static string PROMPT_CONFIRM_LOCALVAULT_PWD {
            get {
                return ResourceManager.GetString("PROMPT_CONFIRM_LOCALVAULT_PWD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to LastPass master password.
        /// </summary>
        internal static string PROMPT_LASTPASS_PWD {
            get {
                return ResourceManager.GetString("PROMPT_LASTPASS_PWD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local vault password.
        /// </summary>
        internal static string PROMPT_LOCALVAULT_PWD {
            get {
                return ResourceManager.GetString("PROMPT_LOCALVAULT_PWD", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} accounts in TOTP vault.
        /// </summary>
        internal static string STATUS_ACCOUNTS_IN_VAULT {
            get {
                return ResourceManager.GetString("STATUS_ACCOUNTS_IN_VAULT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} accounts matched.
        /// </summary>
        internal static string STATUS_ACCOUNTS_MATCHED {
            get {
                return ResourceManager.GetString("STATUS_ACCOUNTS_MATCHED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Decrypting MFA backup....
        /// </summary>
        internal static string STATUS_DECRYPTING_MFA_BACKUP {
            get {
                return ResourceManager.GetString("STATUS_DECRYPTING_MFA_BACKUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dowloading MFA backup....
        /// </summary>
        internal static string STATUS_DOWNLOADING_MFA_BACKUP {
            get {
                return ResourceManager.GetString("STATUS_DOWNLOADING_MFA_BACKUP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Local TOTP vault updated.
        /// </summary>
        internal static string STATUS_LOCALVAULT_UPDATED {
            get {
                return ResourceManager.GetString("STATUS_LOCALVAULT_UPDATED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Logging in....
        /// </summary>
        internal static string STATUS_LOGGING_IN {
            get {
                return ResourceManager.GetString("STATUS_LOGGING_IN", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MFA backup successfully downloaded.
        /// </summary>
        internal static string STATUS_MFA_BACKUP_DOWNLOADED {
            get {
                return ResourceManager.GetString("STATUS_MFA_BACKUP_DOWNLOADED", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving iterations....
        /// </summary>
        internal static string STATUS_RETRIEVING_ITERATIONS {
            get {
                return ResourceManager.GetString("STATUS_RETRIEVING_ITERATIONS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning: it is STRONGLY discouraged to use your LastPass master password for your local TOTP vault.
        /// </summary>
        internal static string WARN_LPMASTERPASSWD_SAME {
            get {
                return ResourceManager.GetString("WARN_LPMASTERPASSWD_SAME", resourceCulture);
            }
        }
    }
}
