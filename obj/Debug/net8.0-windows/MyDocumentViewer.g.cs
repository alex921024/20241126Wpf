﻿#pragma checksum "..\..\..\MyDocumentViewer.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A0742FF7771D5F0EA9F8ED81C3963B8AB00347B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.42000
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
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
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Converters;
using Xceed.Wpf.Toolkit.Core;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Mag.Converters;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;
using _20241126wpf;


namespace _20241126wpf {
    
    
    /// <summary>
    /// MyDocumentViewer
    /// </summary>
    public partial class MyDocumentViewer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar applicationToolBar;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button openButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button trashButton;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ToolBar editingToolBar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton boldButton;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton italicButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton underlineButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.ColorPicker fontColorPicker;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontFamilyComboBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fontSizeComboBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\MyDocumentViewer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbEditor;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/20241126wpf;component/mydocumentviewer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MyDocumentViewer.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 11 "..\..\..\MyDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.NewCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 12 "..\..\..\MyDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.OpenCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 13 "..\..\..\MyDocumentViewer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.SaveCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.applicationToolBar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 5:
            this.newButton = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.openButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.trashButton = ((System.Windows.Controls.Button)(target));
            return;
            case 9:
            this.editingToolBar = ((System.Windows.Controls.ToolBar)(target));
            return;
            case 10:
            this.boldButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 11:
            this.italicButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 12:
            this.underlineButton = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            return;
            case 13:
            this.fontColorPicker = ((Xceed.Wpf.Toolkit.ColorPicker)(target));
            return;
            case 14:
            this.fontFamilyComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 15:
            this.fontSizeComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 16:
            this.rtbEditor = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
