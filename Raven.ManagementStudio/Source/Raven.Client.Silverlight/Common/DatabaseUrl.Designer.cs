﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Raven.Client.Silverlight.Common {
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
    internal class DatabaseUrl {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DatabaseUrl() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Raven.Client.Silverlight.Common.DatabaseUrl", typeof(DatabaseUrl).Assembly);
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
        ///   Looks up a localized string similar to {0}/bulk_docs?.
        /// </summary>
        internal static string DocumentBatch {
            get {
                return ResourceManager.GetString("DocumentBatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/docs/{1}?.
        /// </summary>
        internal static string DocumentGet {
            get {
                return ResourceManager.GetString("DocumentGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/docs?.
        /// </summary>
        internal static string DocumentGetAll {
            get {
                return ResourceManager.GetString("DocumentGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/queries?.
        /// </summary>
        internal static string DocumentGetMany {
            get {
                return ResourceManager.GetString("DocumentGetMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/docs?.
        /// </summary>
        internal static string DocumentPost {
            get {
                return ResourceManager.GetString("DocumentPost", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/docs/{1}?.
        /// </summary>
        internal static string DocumentPut {
            get {
                return ResourceManager.GetString("DocumentPut", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/indexes/{1}?definition=yes&amp;.
        /// </summary>
        internal static string IndexGet {
            get {
                return ResourceManager.GetString("IndexGet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/indexes?.
        /// </summary>
        internal static string IndexGetAll {
            get {
                return ResourceManager.GetString("IndexGetAll", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/indexes?.
        /// </summary>
        internal static string IndexGetMany {
            get {
                return ResourceManager.GetString("IndexGetMany", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}/indexes/{1}?.
        /// </summary>
        internal static string IndexPut {
            get {
                return ResourceManager.GetString("IndexPut", resourceCulture);
            }
        }
    }
}