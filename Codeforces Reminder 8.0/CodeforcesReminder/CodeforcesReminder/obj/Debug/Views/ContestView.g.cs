﻿#pragma checksum "E:\work\Projects x\CodeforcesReminder\Codeforces Reminder\Codeforces Reminder 8.0\CodeforcesReminder\CodeforcesReminder\Views\ContestView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8ED5967FC98F094F394D7F853B8A88FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace CodeforcesReminder.Views {
    
    
    public partial class ContestView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock txtName;
        
        internal System.Windows.Controls.TextBlock txtTime;
        
        internal System.Windows.Controls.TextBlock txtTimeBeforStart;
        
        internal System.Windows.Controls.TextBlock txtTimeZone;
        
        internal System.Windows.Controls.Button bt_Reminder;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/CodeforcesReminder;component/Views/ContestView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtName = ((System.Windows.Controls.TextBlock)(this.FindName("txtName")));
            this.txtTime = ((System.Windows.Controls.TextBlock)(this.FindName("txtTime")));
            this.txtTimeBeforStart = ((System.Windows.Controls.TextBlock)(this.FindName("txtTimeBeforStart")));
            this.txtTimeZone = ((System.Windows.Controls.TextBlock)(this.FindName("txtTimeZone")));
            this.bt_Reminder = ((System.Windows.Controls.Button)(this.FindName("bt_Reminder")));
        }
    }
}

