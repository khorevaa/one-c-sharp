﻿#pragma checksum "..\..\..\Select\SelectView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9EF71EB9FC08ECBF30E42AD88BF08C74CFBCE45"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Zhichkin.Hermes.UI;


namespace Zhichkin.Hermes.UI {
    
    
    /// <summary>
    /// SelectView
    /// </summary>
    public partial class SelectView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Select\SelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander Expander_SELECT;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\Select\SelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander Expander_FROM;
        
        #line default
        #line hidden
        
        
        #line 155 "..\..\..\Select\SelectView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Expander Expander_WHERE;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Zhichkin.Hermes.UI;component/select/selectview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Select\SelectView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 9 "..\..\..\Select\SelectView.xaml"
            ((Zhichkin.Hermes.UI.SelectView)(target)).DragEnter += new System.Windows.DragEventHandler(this.View_DragEnter);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Select\SelectView.xaml"
            ((Zhichkin.Hermes.UI.SelectView)(target)).DragLeave += new System.Windows.DragEventHandler(this.View_DragLeave);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Select\SelectView.xaml"
            ((Zhichkin.Hermes.UI.SelectView)(target)).Drop += new System.Windows.DragEventHandler(this.View_Drop);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Expander_SELECT = ((System.Windows.Controls.Expander)(target));
            return;
            case 3:
            this.Expander_FROM = ((System.Windows.Controls.Expander)(target));
            return;
            case 4:
            this.Expander_WHERE = ((System.Windows.Controls.Expander)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

