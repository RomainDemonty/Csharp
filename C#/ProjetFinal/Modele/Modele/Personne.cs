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

            set { _nom = Nom; }
        }

        public string motDePasse
        {
            get { return _motDePasse; }

            set { _motDePasse = motDePasse; }
        }

        public Personne()
        {
            _motDePasse = "Test";
            _nom = "Test";
        }

        public Personne(string Nom, string motDePasse)
        {
            _motDePasse = motDePasse;
            _nom = Nom;
        }

        public Personne(Personne B)
        {
            _motDePasse = B._motDePasse;
            _nom = B._nom;
        }

    }
}