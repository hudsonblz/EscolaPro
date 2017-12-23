using System;
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

        private void MudarTema_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new MudarTema(ActualHeight, ActualWidth));
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Navegador.Navigate(new Home());
        }
    }
}
