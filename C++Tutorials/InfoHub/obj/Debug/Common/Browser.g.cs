﻿

#pragma checksum "C:\Win8AppMaker\C++Tutorials\InfoHub\Common\Browser.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4F0E557B86712B3950E403D91F939353"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InfoHub.Common
{
    partial class Browser : global::Windows.UI.Xaml.Controls.UserControl, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 29 "..\..\Common\Browser.xaml"
                ((global::Windows.UI.Xaml.UIElement)(target)).Tapped += this.ItemsList_Tapped;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 35 "..\..\Common\Browser.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.MyBackButton_Click_1;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 49 "..\..\Common\Browser.xaml"
                ((global::Windows.UI.Xaml.Controls.WebView)(target)).LoadCompleted += this.MyWebView_LoadCompleted;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}

