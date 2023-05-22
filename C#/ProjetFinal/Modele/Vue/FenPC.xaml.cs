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
using System.Windows.Shapes;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour FenPC.xaml
    /// </summary>
    public partial class FenPC : Window
    {
        public FenPC()
        {
            InitializeComponent();
        }

        private void ClickBouttonAjoutSupp(object sender, RoutedEventArgs e)
        {

        }

        private void ClickBouttonSupprimer(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FenCompo fenpc = new FenCompo();
            fenpc.Show();
            this.Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
