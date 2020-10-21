﻿#pragma checksum "..\..\UserControlItem.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17A1DCC154E08EEF86ABDB56D4F1C147B6138E8142627B6835CB46971ED1B346"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Belajar_CRUD_WPF_Dionisius;
using MaterialDesignThemes.MahApps;
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


namespace Belajar_CRUD_WPF_Dionisius {
    
    
    /// <summary>
    /// UserControlItem
    /// </summary>
    public partial class UserControlItem : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 110 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxId;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxName;
        
        #line default
        #line hidden
        
        
        #line 134 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBoxSupplierId;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxStock;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxPrice;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_input;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_update;
        
        #line default
        #line hidden
        
        
        #line 204 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid TableItem;
        
        #line default
        #line hidden
        
        
        #line 299 "..\..\UserControlItem.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refresh_btn;
        
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
            System.Uri resourceLocater = new System.Uri("/Belajar_CRUD_WPF_Dionisius;component/usercontrolitem.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControlItem.xaml"
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
            this.textBoxId = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.textBoxName = ((System.Windows.Controls.TextBox)(target));
            
            #line 122 "..\..\UserControlItem.xaml"
            this.textBoxName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.textBoxName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.comboBoxSupplierId = ((System.Windows.Controls.ComboBox)(target));
            
            #line 134 "..\..\UserControlItem.xaml"
            this.comboBoxSupplierId.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.comboBoxSupplierId_SelectionChanged_1);
            
            #line default
            #line hidden
            return;
            case 4:
            this.textBoxStock = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.textBoxPrice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btn_input = ((System.Windows.Controls.Button)(target));
            
            #line 166 "..\..\UserControlItem.xaml"
            this.btn_input.Click += new System.Windows.RoutedEventHandler(this.ButtonInputClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btn_update = ((System.Windows.Controls.Button)(target));
            
            #line 177 "..\..\UserControlItem.xaml"
            this.btn_update.Click += new System.Windows.RoutedEventHandler(this.ButtonUpdateClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TableItem = ((System.Windows.Controls.DataGrid)(target));
            
            #line 205 "..\..\UserControlItem.xaml"
            this.TableItem.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TableItem_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.refresh_btn = ((System.Windows.Controls.Button)(target));
            
            #line 300 "..\..\UserControlItem.xaml"
            this.refresh_btn.Click += new System.Windows.RoutedEventHandler(this.refresh_btn_Click);
            
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
            case 9:
            
            #line 283 "..\..\UserControlItem.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ButtonDeleteClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

