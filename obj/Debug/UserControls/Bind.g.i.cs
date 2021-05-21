﻿#pragma checksum "..\..\..\UserControls\Bind.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "50C819232CBB9C4C92CEA0FE05B5EBC1171D0992C1939C6DEF274890FA0FD0AD"
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


namespace EssentialMacros.UserControls {
    
    
    /// <summary>
    /// Bind
    /// </summary>
    public partial class Bind : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BindName;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UnbindContainer;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button UnbindButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RebindContainer;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RebindButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BindKeyLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BindContainer;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UserControls\Bind.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BindButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EssentialMacros;component/usercontrols/bind.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\Bind.xaml"
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
            this.BindName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.UnbindContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.UnbindButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\UserControls\Bind.xaml"
            this.UnbindButton.Click += new System.Windows.RoutedEventHandler(this.UnbindButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RebindContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.RebindButton = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UserControls\Bind.xaml"
            this.RebindButton.Click += new System.Windows.RoutedEventHandler(this.RebindButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BindKeyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.BindContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.BindButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UserControls\Bind.xaml"
            this.BindButton.Click += new System.Windows.RoutedEventHandler(this.BindButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
