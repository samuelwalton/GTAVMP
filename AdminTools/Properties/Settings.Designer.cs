﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KickOnDefaultName {
            get {
                return ((bool)(this["KickOnDefaultName"]));
            }
            set {
                this["KickOnDefaultName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KickOnNameDifference {
            get {
                return ((bool)(this["KickOnNameDifference"]));
            }
            set {
                this["KickOnNameDifference"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SocialClubOnly {
            get {
                return ((bool)(this["SocialClubOnly"]));
            }
            set {
                this["SocialClubOnly"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Welcome to the SL Development Server! Max Ping: 250")]
        public string MOTD {
            get {
                return ((string)(this["MOTD"]));
            }
            set {
                this["MOTD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("250")]
        public int MaxPing {
            get {
                return ((int)(this["MaxPing"]));
            }
            set {
                this["MaxPing"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AntiClones {
            get {
                return ((bool)(this["AntiClones"]));
            }
            set {
                this["AntiClones"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool KickOnOutdatedScript {
            get {
                return ((bool)(this["KickOnOutdatedScript"]));
            }
            set {
                this["KickOnOutdatedScript"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool KickOnOutdatedGame {
            get {
                return ((bool)(this["KickOnOutdatedGame"]));
            }
            set {
                this["KickOnOutdatedGame"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("VERSION_0_9")]
        public string ScriptVersion {
            get {
                return ((string)(this["ScriptVersion"]));
            }
            set {
                this["ScriptVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("26")]
        public string GameVersion {
            get {
                return ((string)(this["GameVersion"]));
            }
            set {
                this["GameVersion"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ColoredNicknames {
            get {
                return ((bool)(this["ColoredNicknames"]));
            }
            set {
                this["ColoredNicknames"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[~h~EU~n~/~b~G~r~E~y~R~n~] -=[ Seven-Labs Development Server ]=-")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
            set {
                this["ServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool OnlyAsciiNickName {
            get {
                return ((bool)(this["OnlyAsciiNickName"]));
            }
            set {
                this["OnlyAsciiNickName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool OnlyAsciiUserName {
            get {
                return ((bool)(this["OnlyAsciiUserName"]));
            }
            set {
                this["OnlyAsciiUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LimitNickNames {
            get {
                return ((bool)(this["LimitNickNames"]));
            }
            set {
                this["LimitNickNames"] = value;
            }
        }
    }
}
