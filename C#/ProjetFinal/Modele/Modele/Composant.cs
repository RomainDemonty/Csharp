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
        private string _categorie;
        private float _prix;

        public float Prix
        {
            get { return _prix; }

            set { _prix = Prix; }
        }

        public string Categorie
        {
            get { return _categorie; }

            set { _categorie = Categorie; }
        }

        public string NomComp
        {
            get { return _nomComp; }

            set { _nomComp = Categorie; }
        }

        public Composant(string NomComp, string Categorie, float Prix)
        {
            _nomComp = NomComp;
            _categorie = Categorie;
            _prix = Prix;
        }
    }
}
