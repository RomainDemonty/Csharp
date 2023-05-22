using System.Collections.ObjectModel;

namespace Modele
{
    [Serializable]
    public class Personne
    {
        private string _nom;
        private string _motDePasse;

        public string Nom
        {
            get { return _nom; }

            set { _nom = value; }
        }

        public string motDePasse
        {
            get { return _motDePasse; }

            set { _motDePasse = value; }
        }

        public Personne()
        {
            _motDePasse = "Test";
            _nom = "Test";
        }

        public Personne(string n, string mdp)
        {
            motDePasse = mdp;
            Nom = n;
        }

        

    }
}