﻿#pragma checksum "..\..\CriarChamada.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40C0C396B0F5FD7C1E3E136AA57BB4B3B6627D13"
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
    /// CriarChamada
    /// </summary>
    public partial class CriarChamada : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxBuscaProfessor;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxBuscaTurma;
        
        #line default
        #line hidden
        
        
        #line 145 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dtpData;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxProfessor;
        
        #line default
        #line hidden
        
        
        #line 198 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbProfessorPresente;
        
        #line default
        #line hidden
        
        
        #line 223 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ltbListaAlunos;
        
        #line default
        #line hidden
        
        
        #line 281 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAlterar;
        
        #line default
        #line hidden
        
        
        #line 292 "..\..\CriarChamada.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancelar;
        
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
            System.Uri resourceLocater = new System.Uri("/EscolaPro;component/criarchamada.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CriarChamada.xaml"
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
            this.cbxBuscaProfessor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cbxBuscaTurma = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.dtpData = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.cbxProfessor = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ckbProfessorPresente = ((System.Windows.Controls.CheckBox)(target));
            
            #line 203 "..\..\CriarChamada.xaml"
            this.ckbProfessorPresente.Click += new System.Windows.RoutedEventHandler(this.ckbProfessorPresente_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ltbListaAlunos = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.BtnAlterar = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.BtnCancelar = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

