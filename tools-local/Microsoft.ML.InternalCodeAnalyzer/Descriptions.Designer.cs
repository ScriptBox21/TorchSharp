﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.ML.InternalCodeAnalyzer
{
    using System.Reflection;


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
    internal class Descriptions {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Descriptions() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.ML.InternalCodeAnalyzer.Descriptions", typeof(Descriptions).GetTypeInfo().Assembly);
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
        ///   Looks up a localized string similar to Since C# has no concept of lazy evaluation of parameters, we prefer Contracts.Check&apos;s message arguments to not involve string formatting, or other complex operations, since such operations will happen always, whether the check fails or not. If you want to have detailed messages that&apos;s great, but use Contracts.Except instead. That is instead of something like &apos;Check(c, msg)&apos;, prefer &apos;if (!c) throw Except(msg)&apos;..
        /// </summary>
        internal static string ContractsCheckMessageNotLiteralOrIdentifier {
            get {
                return ResourceManager.GetString("ContractsCheckMessageNotLiteralOrIdentifier", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to All instance fields or properties should be initialized in a constructor, not in the field. C# allows yone to specify initializers on instance members in either the constructor, or just on the field itself. However, taking advantage of that capability means that to comprehend the post-constructor state of an object a reader will have to read at least two places. To help keep code more comprehensible we disallow using field initializers, and insist that everything be in the constructor. Obviously this does n [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string InstanceInitializerInConstructor {
            get {
                return ResourceManager.GetString("InstanceInitializerInConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CheckDecode and ExceptDecode are used to report badly formatted data. If a message is provided then users expect that to be something actionable. So: if it is data the user themselves formatted or provided, then messages here are really useful. However, if in the context of a ModelLoadContext, this is practically always data Microsoft.ML formatted itself, and users inevitably find the specifics here confusing because they suppose these details are something they can do something about. So: generally, we sho [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string NoMessagesForLoadContext {
            get {
                return ResourceManager.GetString("NoMessagesForLoadContext", resourceCulture);
            }
        }
    }
}