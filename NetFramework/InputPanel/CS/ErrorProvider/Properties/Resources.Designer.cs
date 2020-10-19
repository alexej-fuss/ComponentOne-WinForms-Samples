﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErrorProvider.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ErrorProvider.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Please enter values that add up to at least &lt;b&gt;100&lt;/b&gt;..
        /// </summary>
        internal static string Err100 {
            get {
                return ResourceManager.GetString("Err100", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a time &lt;b&gt;after&lt;/b&gt; 12:00.&lt;br&gt;Anything earlier than that is uncivilized....
        /// </summary>
        internal static string ErrAfter12 {
            get {
                return ResourceManager.GetString("ErrAfter12", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter an &lt;b&gt;even&lt;/b&gt; number.&lt;br&gt;
        ///&lt;i&gt;In case you have forgotten (nothing to be
        ///ashamed of ;-), even numbers are&lt;br&gt;
        ///&lt;b&gt;integers&lt;/b&gt; divisible by 2 with no
        ///remainder (e.g. 0, 2, 4, 6, etc.)&lt;/i&gt;.
        /// </summary>
        internal static string ErrEven {
            get {
                return ResourceManager.GetString("ErrEven", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please check at least one of the checkboxes,&lt;br&gt; otherwise I won&apos;t know what to do....
        /// </summary>
        internal static string ErrOneBox {
            get {
                return ResourceManager.GetString("ErrOneBox", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ErrorInfo {
            get {
                object obj = ResourceManager.GetObject("ErrorInfo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please enter a value that starts with &lt;b&gt;&apos;a&apos;&lt;/b&gt; (lowercase).&lt;br&gt;
        ///&lt;i&gt;Other values are not accepted because they
        ///will compromise our sorting algorithm.
        ///&lt;br&gt;We will get this fixed eventually, but
        ///for now please oblige... &lt;b&gt;Thank you!&lt;/b&gt;&lt;/i&gt;..
        /// </summary>
        internal static string ErrStartWithA {
            get {
                return ResourceManager.GetString("ErrStartWithA", resourceCulture);
            }
        }
    }
}