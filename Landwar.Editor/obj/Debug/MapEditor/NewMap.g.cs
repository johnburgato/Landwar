﻿#pragma checksum "..\..\..\MapEditor\NewMap.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C83358AB8EE7A3A608938001F75B359E"
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


namespace Landwar.Editor.MapEditor {
    
    
    /// <summary>
    /// NewMap
    /// </summary>
    public partial class NewMap : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.Label lblMapName;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.TextBox txtMapName;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.Label lblMapDescription;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.TextBox txtDescription;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.Label lblHeight;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.Label lblWidth;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.TextBox txtHeight;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.TextBox txtWidth;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\MapEditor\NewMap.xaml"
        internal System.Windows.Controls.Button btnCreate;
        
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
            System.Uri resourceLocater = new System.Uri("/Landwar.Editor;component/mapeditor/newmap.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MapEditor\NewMap.xaml"
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
            this.lblMapName = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.txtMapName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.lblMapDescription = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.txtDescription = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.lblHeight = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lblWidth = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.txtHeight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtWidth = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\MapEditor\NewMap.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
