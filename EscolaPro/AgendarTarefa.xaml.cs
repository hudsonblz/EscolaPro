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

namespace EscolaPro
{
    /// <summary>
    /// Interação lógica para AgendarTarefa.xam
    /// </summary>
    public partial class AgendarTarefa : UserControl
    {
        public AgendarTarefa()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, RoutedEventArgs e)
        {
            txbTarefa.Text = null;
        }
    }
}
