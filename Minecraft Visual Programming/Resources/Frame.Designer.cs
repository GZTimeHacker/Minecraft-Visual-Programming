﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Minecraft_Visual_Programming.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Frame {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Frame() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Minecraft_Visual_Programming.Resources.Frame", typeof(Frame).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 challenge 的本地化字符串。
        /// </summary>
        internal static string challenge {
            get {
                return ResourceManager.GetString("challenge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 有穗的边框 的本地化字符串。
        /// </summary>
        internal static string D_challenge {
            get {
                return ResourceManager.GetString("D_challenge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 更圆的边框 的本地化字符串。
        /// </summary>
        internal static string D_goal {
            get {
                return ResourceManager.GetString("D_goal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 普通进度边框 的本地化字符串。
        /// </summary>
        internal static string D_task {
            get {
                return ResourceManager.GetString("D_task", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 goal 的本地化字符串。
        /// </summary>
        internal static string goal {
            get {
                return ResourceManager.GetString("goal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 task 的本地化字符串。
        /// </summary>
        internal static string task {
            get {
                return ResourceManager.GetString("task", resourceCulture);
            }
        }
    }
}
