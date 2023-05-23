using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using Modele;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour FenCompo.xaml
    /// </summary>
    public partial class FenCompo : Window
    {
        int Cat = 1;
        public FenCompo()
        {
            InitializeComponent();
            /*
            if (File.Exists("Donnees"))
            {
                Conteneur.Instance = Serializer.DeserializeJson("Donnees");
            }
            ¨*/
            DataContext = Conteneur.Instance;
        }

        private void ClickBouttonSupprimer(object sender, RoutedEventArgs e)
        {
            if (Conteneur.Instance.SelectedCompo == null)
            {
                MessageBox.Show("Aucune selection");
            }
            else
            {
                Conteneur.Instance.SuppressionComp(Conteneur.Instance.SelectedCompo);
                Serializer.SerializeJson(Conteneur.Instance, "Donnees.json");
            }
        }

        private void ClickBouttonAjouterSupprimer(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Euro.Text)|| string.IsNullOrEmpty(Name.Text) || Box.SelectedItem == null)
                {
                    if (string.IsNullOrEmpty(Euro.Text))
                    {
                        MessageBox.Show("Le prix ne peut pas être vide !");
                    }
                    if (string.IsNullOrEmpty(Name.Text))
                    {
                        MessageBox.Show("Les champs doivent être rempli !", "Erreur", MessageBoxButton.OKCancel);
                    }                
                    if (Box.SelectedItem == null)
                    {
                        MessageBox.Show("Choisissez une catégorie!");
                    }
                }
                else
                {
                    if (float.TryParse(Euro.Text, out float P) && P < 0)
                    {
                        MessageBox.Show("Le prix ne peut pas être négatif!");
                    }
                    else
                    {
                        switch (Box.SelectedItem.ToString())
                        {
                            case "Processeur":
                                Cat = 1;
                                break;
                            case "Carte mère":
                                Cat = 2;
                                break;
                            case "Ram":
                                Cat = 3;
                                break;
                            case "Refroidissement":
                                Cat = 4;
                                break;
                            case "Stockage":
                                Cat = 5;
                                break;
                            case "Système d'exploitation":
                                Cat = 6;
                                break;
                            case "Boitier":
                                Cat = 7;
                                break;
                            case "Carte graphique":
                                Cat = 8;
                                break;
                            case "Alimentation":
                                Cat = 9;
                                break;
                        }
                        Composant composantADD = new Composant(Name.Text, Cat , P);

                        Conteneur.Instance.VecComposants.Add(composantADD);
                        Serializer.SerializeJson(Conteneur.Instance, "Donnees.json");
                }
                }

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
