﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AcerFanControl.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AcerFanControl.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        ///
        ///&lt;configuration&gt;		
        ///
        ///	&lt;fanprofiles&gt;
        ///		&lt;profile default=&quot;true&quot;&gt;
        ///			&lt;name&gt;Quiet&lt;/name&gt;
        ///			&lt;interval&gt;1000&lt;/interval&gt;
        ///			&lt;hysteresis_up&gt;3&lt;/hysteresis_up&gt;
        ///			&lt;hysteresis_down&gt;4&lt;/hysteresis_down&gt;
        ///			&lt;point temp=&quot;0&quot; fan=&quot;20&quot; /&gt;
        ///			&lt;point temp=&quot;40&quot; fan=&quot;25&quot; /&gt;
        ///			&lt;point temp=&quot;55&quot; fan=&quot;50&quot; /&gt;
        ///			&lt;point temp=&quot;60&quot; fan=&quot;65&quot; /&gt;
        ///			&lt;point temp=&quot;65&quot; fan=&quot;100&quot; /&gt;
        ///		&lt;/profile&gt;
        ///		&lt;profile&gt;
        ///			&lt;name&gt;Cool&lt;/name&gt;
        ///			&lt;interval&gt;1000&lt;/interval&gt;
        ///			&lt;hysteresis_up&gt;2&lt;/hysteres [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string defaultConfigXML {
            get {
                return ResourceManager.GetString("defaultConfigXML", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap font16 {
            get {
                object obj = ResourceManager.GetObject("font16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap icon16 {
            get {
                object obj = ResourceManager.GetObject("icon16", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}