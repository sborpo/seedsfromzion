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
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("seedsfromzion.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to /*The background of the page , something green*/
        ///.sign {width:100%;
        ///	color:black}
        ///body
        ///{
        ///background-color:white;
        ///}
        ////*headings will be a color close to white*/
        ///.signature { color:black ; font-size:12px; font-family:&quot;Times New Roman&quot;, Times, serif;}
        ///p { color:black;}
        ///.line {color: black; height: 1px;}
        ///.maintable {color:black; border: 1px solid black; border-collapse:collapse;}
        ///td {padding:15px; border: 1px solid black;}
        ///th {background-color:black; color:white; border: 1px solid black;}
        ///.tdsign{  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string blackAndWhiteStyle {
            get {
                return ResourceManager.GetString("blackAndWhiteStyle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to /*The background of the page , something green*/
        ///.sign {width:100%;
        ///	color:black}
        ///body
        ///{
        ///background-color:#f4ffd8;
        ///}
        ////*headings will be a color close to white*/
        ///.signature { color:green ; font-size:12px; font-family:&quot;Times New Roman&quot;, Times, serif;}
        ///p { color:black;}
        ///.line {color: #f00; height: 1px;}
        ///.maintable {color:black; border: 1px solid black; border-collapse:collapse;}
        ///td {padding:15px; border: 1px solid green;}
        ///th {background-color:green; color:white; border: 1px solid green;}
        ///.tdsign{ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string colorStyle {
            get {
                return ResourceManager.GetString("colorStyle", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ico {
            get {
                object obj = ResourceManager.GetObject("ico", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}