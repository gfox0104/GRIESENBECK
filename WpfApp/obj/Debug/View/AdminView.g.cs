﻿#pragma checksum "..\..\..\View\AdminView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8FCEE4B8EDA7627CD3A673E70B1D75363E591B67"
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
using WpfApp.Converter;
using WpfApp.View;


namespace WpfApp.View {
    
    
    /// <summary>
    /// AdminView
    /// </summary>
    public partial class AdminView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp;component/view/adminview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AdminView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            
            #line 31 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GoBack);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 2:
            
            #line 243 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustomerNote_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 3:
            
            #line 318 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustPM_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 331 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustPM_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 5:
            
            #line 344 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustPM_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 6:
            
            #line 357 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CustPM_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 357 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CustPM_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 7:
            
            #line 370 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustPM_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 8:
            
            #line 424 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.PMNote_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 9:
            
            #line 471 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustSupt_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 10:
            
            #line 484 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustSupt_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 11:
            
            #line 497 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustSupt_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 510 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CustSupt_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 510 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CustSupt_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 13:
            
            #line 523 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustSupt_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 577 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.SuptNote_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 15:
            
            #line 624 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustContact_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 16:
            
            #line 637 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustContact_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 17:
            
            #line 650 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustContact_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 18:
            
            #line 663 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Checked += new System.Windows.RoutedEventHandler(this.CustContact_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 663 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.CheckBox)(target)).Unchecked += new System.Windows.RoutedEventHandler(this.CustContact_ChkPreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 19:
            
            #line 676 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustContact_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 20:
            
            #line 730 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.SubmNote_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 21:
            
            #line 781 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.CustomerTab_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            case 22:
            
            #line 993 "..\..\..\View\AdminView.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.ManufNote_PreviewKeyUp);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

