﻿#pragma checksum "..\..\Wordstrainer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3B78E763D74E6C29CF227E80A33E7893"
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
using VokabelTrainer;


namespace VokabelTrainer {
    
    
    /// <summary>
    /// Wordstrainer
    /// </summary>
    public partial class Wordstrainer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBoxTranslation;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelStartVocab;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelTranslationFromTo;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label labelQuestionsSolved;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonSkip;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonShow;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCheck;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imageStatus;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\Wordstrainer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/VokabelTrainer;component/wordstrainer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Wordstrainer.xaml"
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
            this.textBoxTranslation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.labelStartVocab = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.labelTranslationFromTo = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.labelQuestionsSolved = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.buttonSkip = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.buttonShow = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.buttonCheck = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.imageStatus = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.buttonCancel = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

