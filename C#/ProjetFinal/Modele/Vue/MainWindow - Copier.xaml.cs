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
using System.Windows.Navigation;
using System.Windows.Shapes;

using Newtonsoft.Json;
using Modele;

namespace Vue
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickBouttonInscrire(object sender, RoutedEventArgs e)
        {
            string name = NomPersonneTextBox.Text;
            string mdp = MdpPersonneTextBox.Text;
            int existe = 0;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mdp))
            {    
                MessageBox.Show("Les champs doivent être rempli !" ,"Erreur", MessageBoxButton.OKCancel);
            }
            else
            {

                Personne PersonneADD = new Personne(name, mdp);

                existe = Conteneur.GetAllConteneur().VerifPer(PersonneADD);

                if (existe==1)
                {
                    //sinon mettre utilisateur déjà existant
                    MessageBox.Show("L'utilisateur est déjà existant !" ,"Erreur", MessageBoxButton.OKCancel);
                }
                else
                {
                    //list.Add(PersonneADD);

                    //Ecriture
                    Conteneur.GetAllConteneur().AjouterPer(PersonneADD);
                    Serializer.SerializeJson(Conteneur.GetAllConteneur(), "Donnee");

                    //si existe pas rediriger vers une autre page
                    FenCompo fenCompo = new FenCompo();
                    fenCompo.Show();
                    this.Close();
                }
            }

        }

        private void ClickBouttonConnect(object sender, RoutedEventArgs e)
        {
            string name = NomPersonneTextBox.Text;
            string mdp = MdpPersonneTextBox.Text;
            int existe = 0;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Les champs doivent être rempli !", "Erreur", MessageBoxButton.OKCancel);
            }
            else
            {
                Personne PersonneADD = new Personne(name, mdp);

                existe = Conteneur.GetAllConteneur().VerifPer(PersonneADD);

                if (existe != 2)
                {
                    //sinon mettre utilisateur déjà existant
                    MessageBox.Show("Données invalide !", "Erreur", MessageBoxButton.OKCancel);
                }
                else
                {
                    //Ecriture
                    Conteneur.GetAllConteneur().AjouterPer(PersonneADD);
                    Serializer.SerializeJson(Conteneur.GetAllConteneur(), "Donnee");

                    //si existe pas rediriger vers une autre page
                    FenCompo fenCompo = new FenCompo();
                    fenCompo.Show();
                    this.Close();
                }
            }
        }
    }
}
