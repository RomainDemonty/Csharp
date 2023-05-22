using Modele;
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
using System.IO;
using System.Windows.Markup;

namespace Vue
{
    /// <summary>
    /// Logique d'interaction pour WindowConnection.xaml
    /// </summary>
    public partial class WindowConnection : Window
    {
        public WindowConnection()
        {
            InitializeComponent();

            if (File.Exists("Donnees"))
            {
                Conteneur.Instance = Serializer.DeserializeJson("Donnees");
            }
        }

        private void ClickBouttonInscrire(object sender, RoutedEventArgs e)
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

                existe = Conteneur.Instance.VerifPer(PersonneADD);

                if (existe == 1 )
                {
                    //sinon mettre utilisateur déjà existant
                    MessageBox.Show("L'utilisateur est déjà existant !", "Erreur", MessageBoxButton.OKCancel);
                }
                else
                {
                   
                    //Ecriture
                    Conteneur.Instance.VecPersonnes.Add(PersonneADD);
                    Serializer.SerializeJson(Conteneur.Instance, "Donnees");

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
           bool trouve = false;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Les champs doivent être rempli !", "Erreur", MessageBoxButton.OKCancel);
            }
            else
            {

                foreach (Personne personne in Conteneur.Instance.VecPersonnes)
                {
                    if (name == personne.Nom && mdp == personne.motDePasse)
                    {
                        trouve = true;
                        FenCompo fenCompo = new FenCompo();
                        fenCompo.Show();
                        this.Close();

                    }
                }
                // Vérifier si le nom d'utilisateur et le mot de passe sont corrects

                if (!trouve)
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }
    }
}
