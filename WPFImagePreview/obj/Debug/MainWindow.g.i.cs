﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1EBB08012B1F93A6F7DC8CE9C3B33C4FA793BA1A1C76AC4196F6F952B5203C6D"
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
using WPFImagePreview;


namespace WPFImagePreview {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border border;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgPreview;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZoomIn;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnZoomOut;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnRotate;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgOne;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgTwo;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgThree;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgFour;
        
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
            System.Uri resourceLocater = new System.Uri("/WPFImagePreview;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.border = ((System.Windows.Controls.Border)(target));
            return;
            case 2:
            this.ImgPreview = ((System.Windows.Controls.Image)(target));
            
            #line 26 "..\..\MainWindow.xaml"
            this.ImgPreview.MouseMove += new System.Windows.Input.MouseEventHandler(this.ImgPreview_MouseMove);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.ImgPreview.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgPreview_MouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            this.ImgPreview.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ImgPreview_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnZoomIn = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\MainWindow.xaml"
            this.BtnZoomIn.Click += new System.Windows.RoutedEventHandler(this.BtnZoomIn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnZoomOut = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\MainWindow.xaml"
            this.BtnZoomOut.Click += new System.Windows.RoutedEventHandler(this.BtnZoomOut_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BtnRotate = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\MainWindow.xaml"
            this.BtnRotate.Click += new System.Windows.RoutedEventHandler(this.BtnRotate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ImgOne = ((System.Windows.Controls.Image)(target));
            
            #line 50 "..\..\MainWindow.xaml"
            this.ImgOne.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgOne_MouseDown);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ImgTwo = ((System.Windows.Controls.Image)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.ImgTwo.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgTwo_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ImgThree = ((System.Windows.Controls.Image)(target));
            
            #line 54 "..\..\MainWindow.xaml"
            this.ImgThree.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgThree_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.ImgFour = ((System.Windows.Controls.Image)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.ImgFour.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgFour_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
