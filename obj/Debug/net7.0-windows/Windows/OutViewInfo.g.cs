﻿#pragma checksum "..\..\..\..\Windows\OutViewInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D523E1559616771771CB5EC44C51A5A27CBEEBD6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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
using demopract2024_2.Windows;


namespace demopract2024_2.Windows {
    
    
    /// <summary>
    /// OutViewInfo
    /// </summary>
    public partial class OutViewInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearth;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboManufacturer;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboCost;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TBCountDataOut;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListViewOut;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Add;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\Windows\OutViewInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Button_Edit;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/demopract2024_2;component/windows/outviewinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\OutViewInfo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBSearth = ((System.Windows.Controls.TextBox)(target));
            
            #line 27 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.TBSearth.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearth_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboManufacturer = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.ComboManufacturer.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboManufacturer_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ComboCost = ((System.Windows.Controls.ComboBox)(target));
            
            #line 37 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.ComboCost.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboCost_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TBCountDataOut = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ListViewOut = ((System.Windows.Controls.ListView)(target));
            
            #line 43 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.ListViewOut.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListViewOut_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Button_Add = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.Button_Add.Click += new System.Windows.RoutedEventHandler(this.Button_Add_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Button_Edit = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\..\Windows\OutViewInfo.xaml"
            this.Button_Edit.Click += new System.Windows.RoutedEventHandler(this.Button_Edit_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

