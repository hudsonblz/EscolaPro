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
        }

        private void AlunoResponsavel_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)AlunoResponsavel.IsChecked)
            {
                Responsavel.IsEnabled = true;
                Responsavel.Visibility = Visibility.Hidden;
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CPF, "CPF do Responsável");
            }
            else
            {
                Responsavel.IsEnabled = true;
                Responsavel.Visibility = Visibility.Visible;
                MaterialDesignThemes.Wpf.HintAssist.SetHint(CPF, "CPF do Aluno");
            }
        }
    }
}
