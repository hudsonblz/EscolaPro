﻿#pragma checksum "..\..\MudarTema.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D3372DBD4A8655607DC2472FF9DEC911E3CD364"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using EscolaPro;
using MaterialDesignThemes.Wpf;
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


namespace EscolaPro {
    
    
    /// <summary>
    /// MudarTema
    /// </summary>
    public partial class MudarTema : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 91 "..\..\MudarTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxTema;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\MudarTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxCor;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\MudarTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxDestaque;
        
        #line default
        #line hidden
        
        
        #line 132 "..\..\MudarTema.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Salva;
        
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
            System.Uri resourceLocater = new System.Uri("/EscolaPro;component/mudartema.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MudarTema.xaml"
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
            this.cbxTema = ((System.Windows.Controls.ComboBox)(target));
            
            #line 98 "..\..\MudarTema.xaml"
            this.cbxTema.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxTema_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbxCor = ((System.Windows.Controls.ComboBox)(target));
            
            #line 114 "..\..\MudarTema.xaml"
            this.cbxCor.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxCor_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cbxDestaque = ((System.Windows.Controls.ComboBox)(target));
            
            #line 130 "..\..\MudarTema.xaml"
            this.cbxDestaque.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbxDestaque_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Salva = ((System.Windows.Controls.Button)(target));
            
            #line 136 "..\..\MudarTema.xaml"
            this.Salva.Click += new System.Windows.RoutedEventHandler(this.Salva_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

