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
    /// Interação lógica para CadastrarAluno.xam
    /// </summary>
    public partial class AlterarAluno : UserControl
    {
        public AlterarAluno()
        {
            InitializeComponent();
            InfoResponsavel.Visibility = Visibility.Collapsed;
        }

        private void AlunoResponsavel_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)AlunoResponsavel.IsChecked)
            {
                InfoResponsavel.IsEnabled = true;
                InfoResponsavel.Visibility = Visibility.Collapsed;
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CPF, "CPF do Aluno");
            }
            else
            {
                InfoResponsavel.IsEnabled = true;
                InfoResponsavel.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CPF, "CPF do Responsável Contrato");
            }
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            InfoAluno.Visibility = Visibility.Visible;
        }
    }
}
