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
    /// Logique d'interaction pour FenCompo.xaml
    /// </summary>
    public partial class FenCompo : Window
    {
        public FenCompo()
        {
            InitializeComponent();
        }

        private void ClickBouttonSupprimer(object sender, RoutedEventArgs e)
        {

        }

        private void ClickBouttonAjouterSupprimer(object sender, RoutedEventArgs e)
        {

        }

        //Quitter du menu
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Premier du menu
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            FenPC fenpc = new FenPC();
            fenpc.Show();
            this.Close();
        }
    }
}
