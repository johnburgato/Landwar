﻿#pragma checksum "..\..\Page1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D4D6ABE5EC2CF6DB6C1B635707EF3A8"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4206
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


namespace Landwar.Editor {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\Page1.xaml"
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Page1.xaml"
        internal System.Windows.Controls.Canvas canvas1;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Page1.xaml"
        internal System.Windows.Shapes.Polygon pGon1;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Page1.xaml"
        internal System.Windows.Controls.Label lblOutput;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Landwar.Editor;component/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Page1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.canvas1 = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.pGon1 = ((System.Windows.Shapes.Polygon)(target));
            
            #line 14 "..\..\Page1.xaml"
            this.pGon1.MouseMove += new System.Windows.Input.MouseEventHandler(this.Polygon_MouseMove);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblOutput = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}