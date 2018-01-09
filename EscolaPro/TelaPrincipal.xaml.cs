﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MaterialDesignThemes;
namespace EscolaPro
{
    /// <summary>
    /// Interação lógica para TelaPrincipal.xaml
    /// </summary>
    public partial class TelaPrincipal : Window
    {
        public TelaPrincipal()
        {
            MudarCores iniciarTema = new MudarCores();
            InitializeComponent();
            Navegador.Navigate(new Home());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Navegador.Height = ActualHeight - 60;
            //Navegador.Width = ActualWidth - 60;
            //Navegador.Navigate(new Conferencia(ActualHeight, ActualWidth));
        }

        private void btnMudarTema_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new MudarTema(ActualHeight, ActualWidth));
        }

        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new Home());
        }

        private void btnSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void btnCadastrarAluno_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new CadastrarAluno());
        }

        private void btnAgendarTarefa_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new AgendarTarefa());
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ScroolPrincipal.Height = ActualHeight - 110;
            ScroolPrincipal.Width = ActualWidth - 20;
        }

        private void Window_StateChanged(object sender, EventArgs e)
        {
            ScroolPrincipal.Height = ActualHeight - 110;
            ScroolPrincipal.Width = ActualWidth - 20;
        }

        private void btnAlterarAluno_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new AlterarAluno());
        }

        private void btnCadastrarTurma_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new CriarTurma());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new AlterarTurma());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new BuscarTurma());
        }
    }
}
