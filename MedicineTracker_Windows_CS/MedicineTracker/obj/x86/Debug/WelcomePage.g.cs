﻿#pragma checksum "C:\Users\dmcga\OneDrive\Documents\GitHub\Universal-Windows-App\MedicineTracker_Windows_CS\MedicineTracker\WelcomePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5A2C905B9D558429DE50EC5A28DBC188"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedicineTracker
{
    partial class WelcomePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\WelcomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.MenuButton4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\WelcomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton4).Click += this.MenuButton4_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.MenuButton3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 29 "..\..\..\WelcomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton3).Click += this.MenuButton3_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.MenuButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\WelcomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton2).Click += this.MenuButton2_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.MenuButton1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 19 "..\..\..\WelcomePage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton1).Click += this.MenuButton1_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

