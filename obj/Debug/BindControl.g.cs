#pragma checksum "..\..\BindControl.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC5542BD05093AE8DED4C761CD6F01270BE328747A33AF192F03D16A82294D45"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// BindControl
    /// </summary>
    public partial class BindControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BindName;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid UnbindContainer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid BindContainer;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BindButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BindKeyLabel;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid RebindContainer;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\BindControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RebindButton;
        
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
            System.Uri resourceLocater = new System.Uri("/EssentialMacros;component/bindcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\BindControl.xaml"
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
            
            #line 19 "..\..\BindControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UnbindButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BindContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.BindButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\BindControl.xaml"
            this.BindButton.Click += new System.Windows.RoutedEventHandler(this.BindButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BindKeyLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.RebindContainer = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.RebindButton = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\BindControl.xaml"
            this.RebindButton.KeyDown += new System.Windows.Input.KeyEventHandler(this.RebindButton_KeyDown);
            
            #line default
            #line hidden
            
            #line 30 "..\..\BindControl.xaml"
            this.RebindButton.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.RebindButton_LostKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 30 "..\..\BindControl.xaml"
            this.RebindButton.Click += new System.Windows.RoutedEventHandler(this.BindButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

