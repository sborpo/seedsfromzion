﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3603
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace seedsfromzion.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\Program Files\\MySQL\\MySQL Server 5.1\\bin")]
        public string SqlFolder {
            get {
                return ((string)(this["SqlFolder"]));
            }
            set {
                this["SqlFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Images")]
        public string ImageFolder {
            get {
                return ((string)(this["ImageFolder"]));
            }
            set {
                this["ImageFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Backups")]
        public string BackupFolder {
            get {
                return ((string)(this["BackupFolder"]));
            }
            set {
                this["BackupFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime LastOptimizeDate {
            get {
                return ((global::System.DateTime)(this["LastOptimizeDate"]));
            }
            set {
                this["LastOptimizeDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("12")]
        public int OptimizeFrequency {
            get {
                return ((int)(this["OptimizeFrequency"]));
            }
            set {
                this["OptimizeFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int VisaNotify {
            get {
                return ((int)(this["VisaNotify"]));
            }
            set {
                this["VisaNotify"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int OrderNotify {
            get {
                return ((int)(this["OrderNotify"]));
            }
            set {
                this["OrderNotify"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public int UnitsNotify {
            get {
                return ((int)(this["UnitsNotify"]));
            }
            set {
                this["UnitsNotify"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringCollection Favorites {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["Favorites"]));
            }
            set {
                this["Favorites"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("24")]
        public int VisaFrequency {
            get {
                return ((int)(this["VisaFrequency"]));
            }
            set {
                this["VisaFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("24")]
        public int OrderFrequency {
            get {
                return ((int)(this["OrderFrequency"]));
            }
            set {
                this["OrderFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("48")]
        public int UnitsFrequency {
            get {
                return ((int)(this["UnitsFrequency"]));
            }
            set {
                this["UnitsFrequency"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2012-04-03")]
        public global::System.DateTime LastBackupDate {
            get {
                return ((global::System.DateTime)(this["LastBackupDate"]));
            }
            set {
                this["LastBackupDate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int BackupFrequency {
            get {
                return ((int)(this["BackupFrequency"]));
            }
            set {
                this["BackupFrequency"] = value;
            }
        }
    }
}
