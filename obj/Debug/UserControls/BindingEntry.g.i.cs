﻿#pragma checksum "..\..\..\UserControls\BindingEntry.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EFAB030C515D0FFF5E25BB87D7228DCF542FF04A7731FD5CBAF9F672BABF271C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using EssentialMacros;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace EssentialMacros {
    
    
    /// <summary>
    /// BindingEntry
    /// </summary>
    public partial class BindingEntry : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock WName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox BindKey;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BindButton;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BindButtonText;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border EmptyDark;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border BindHidder;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserControls\BindingEntry.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UnbindButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EssentialMacros;component/usercontrols/bindingentry.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\BindingEntry.xaml"
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
            this.WName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.BindKey = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\..\UserControls\BindingEntry.xaml"
            this.BindKey.KeyDown += new System.Windows.Input.KeyEventHandler(this.BindKey_KeyDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BindButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\UserControls\BindingEntry.xaml"
            this.BindButton.Click += new System.Windows.RoutedEventHandler(this.BindButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BindButtonText = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.EmptyDark = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.BindHidder = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.UnbindButton = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UserControls\BindingEntry.xaml"
            this.UnbindButton.LostFocus += new System.Windows.RoutedEventHandler(this.UnbindButton_LostFocus);
            
            #line default
            #line hidden
            
            #line 31 "..\..\..\UserControls\BindingEntry.xaml"
            this.UnbindButton.Click += new System.Windows.RoutedEventHandler(this.UnbindButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

