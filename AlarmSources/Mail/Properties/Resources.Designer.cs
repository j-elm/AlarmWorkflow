﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlarmWorkflow.AlarmSource.Mail.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AlarmWorkflow.AlarmSource.Mail.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Wertet E-Mails aus, die an ein E-Mail-Konto gesendet werden..
        /// </summary>
        internal static string ExportAlarmSourceDescription {
            get {
                return ResourceManager.GetString("ExportAlarmSourceDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to E-Mail.
        /// </summary>
        internal static string ExportAlarmSourceDisplayName {
            get {
                return ResourceManager.GetString("ExportAlarmSourceDisplayName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping mail because it does not match the configured criteria..
        /// </summary>
        internal static string MailDoesNotMatchCriteria {
            get {
                return ResourceManager.GetString("MailDoesNotMatchCriteria", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipping mail because it does not contain a matching attachment..
        /// </summary>
        internal static string NoAttachmentFound {
            get {
                return ResourceManager.GetString("NoAttachmentFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Received mail from &apos;{0}&apos; with subject &apos;{1}&apos;..
        /// </summary>
        internal static string ReceivedMailInfo {
            get {
                return ResourceManager.GetString("ReceivedMailInfo", resourceCulture);
            }
        }
    }
}
