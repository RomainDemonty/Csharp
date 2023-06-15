using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Microsoft.Win32;
using Modele;

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
            DataContext = Modele.Conteneur.Instance;

            for (int i = 0 ; i < Conteneur.Instance.VecComposants.Count; i++)
            {
                Composant monComposant = new Composant(Conteneur.Instance.VecComposants[i].NomComp, Conteneur.Instance.VecComposants[i].Categorie, Conteneur.Instance.VecComposants[i].Prix);
                switch (Conteneur.Instance.VecComposants[i].Categorie)
                {
                    case 1:
                        BoxProcess.Items.Add(monComposant);
                        break;
                    case 2:
                        BoxCarteMer.Items.Add(monComposant);
                        break;
                    case 3:
                        BoxRam.Items.Add(monComposant);
                        break;
                    case 4:
                        BoxRefroi.Items.Add(monComposant);
                        break;
                    case 5:
                        BoxStock1.Items.Add(monComposant);
                        BoxStock2.Items.Add(monComposant);
                        break;
                    case 6:
                        BoxExploi.Items.Add(monComposant);
                        break;
                    case 7:
                        BoxBoit.Items.Add(monComposant);
                        break;
                    case 8:
                        BoxGraph.Items.Add(monComposant);
                        break;
                    case 9:
                        BoxAlim.Items.Add(monComposant);
                        break;
                }
            }
        }

        private void ClickBouttonAjout(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Composant> vecteurTest = new ObservableCollection<Composant>();

            vecteurTest.Add((Composant)BoxProcess.SelectedItem);
            vecteurTest.Add((Composant)BoxCarteMer.SelectedItem);
            vecteurTest.Add((Composant)BoxRam.SelectedItem);
            vecteurTest.Add((Composant)BoxRefroi.SelectedItem);
            vecteurTest.Add((Composant)BoxStock1.SelectedItem);
            vecteurTest.Add((Composant)BoxStock2.SelectedItem);
            vecteurTest.Add((Composant)BoxExploi.SelectedItem);
            vecteurTest.Add((Composant)BoxBoit.SelectedItem);
            vecteurTest.Add((Composant)BoxGraph.SelectedItem);
            vecteurTest.Add((Composant)BoxAlim.SelectedItem);

            //newPc.Prix = 100;
            float p = new float();

            for (int i = 0 ; i < vecteurTest.Count; i++)
            { 
                p += vecteurTest[i].Prix;
            }

            PC  p2 = new PC(NomPc.Text,image.Text, vecteurTest,DateTime.Now, p);

            Conteneur.Instance.VecPcs.Add(p2);
            Serializer.SerializeJson(Conteneur.Instance, "Donnees.json");
        }

        private void ClickBouttonSupprimer(object sender, RoutedEventArgs e)
        {
            if (Conteneur.Instance.SelectedPC == null)
            {
                MessageBox.Show("Aucune selection");
            }
            else
            {
                Conteneur.Instance.SuppressionPC(Conteneur.Instance.SelectedPC);
                Serializer.SerializeJson(Conteneur.Instance, "Donnees.json");
            }
        }

        private void ClickBouttonModif(object sender, RoutedEventArgs e)
        {
            Serializer.SerializeJson(Conteneur.Instance, "Donnees.json");
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Filtrer les types de fichiers pour afficher uniquement les images
            openFileDialog.Filter = "Fichiers image (*.jpg, *.png, *.gif)|*.jpg;*.png;*.gif";

            openFileDialog.ShowDialog();
            image.Text = openFileDialog.FileName;

        }
    }
}
