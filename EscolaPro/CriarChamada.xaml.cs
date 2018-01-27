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
    /// Interação lógica para CriarChamada.xam
    /// </summary>
    public partial class CriarChamada : UserControl
    {
        public List<tipo> Lista = new List<tipo>();
        public List<string> Professores = new List<string>();
        public CriarChamada()
        {
            InitializeComponent();
            Lista.Add(new tipo() { Nome = "Hudson Mendonca Almeida", Tag = "HA", Presente = true });
            Lista.Add(new tipo() { Nome = "Fabiola Almeida Mendonca", Tag = "FM", Presente = false });
            Lista.Add(new tipo() { Nome = "Irene Mendonca Almeida", Tag = "IA", Presente = true });
            Lista.Add(new tipo() { Nome = "Thais Maria", Tag = "TM", Presente = true });
            Lista.Add(new tipo() { Nome = "Marco Túlio", Tag = "MT", Presente = false });
            Lista.Sort((a, b) => a.Nome.CompareTo(b.Nome));
            ltbListaAlunos.ItemsSource = Lista;

            Professores.Add("Ana Flávia");
            Professores.Add("Carol Carol Carol");
            Professores.Add("Leleca Marinho Navio");
            Professores.Add("Professor XYZ");
            Professores.Sort();
            cbxProfessor.ItemsSource = Professores;

            dtpData.SelectedDate = DateTime.Now;
        }

        private void ckbProfessorPresente_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)ckbProfessorPresente.IsChecked)
                ckbProfessorPresente.Content = "Presente";
            else
                ckbProfessorPresente.Content = "Ausente";
        }
    }

    public class tipo
    {
        public string Nome { get; set; }
        public bool Presente { get; set; }
        public string Tag { get; set; }
    }
}

