using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [Serializable]
    public class Composant
    {
        private string _nomComp;
        private int _categorie;
        private float _prix;

        public float Prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public int Categorie
        {
            get { return _categorie; }

            set { _categorie = value; }
        }

        public string NomComp
        {
            get { return _nomComp; }

            set { _nomComp = value; }
        }

        public Composant()
        {
            _nomComp = "Test";
            _categorie = 1;
            _prix = 100;
        }

        public Composant(string NomComp, int Categorie, float Prix)
        {
            _nomComp = NomComp;
            _categorie = Categorie;
            _prix = Prix;
        }
    }
}
