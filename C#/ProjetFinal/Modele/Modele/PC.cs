using System.Collections.ObjectModel;
using System.Dynamic;

namespace Modele
{
    [Serializable]
    public class PC
    {
        private string _nomPc;
        private string _image;
        private DateTime _date;
        private float _prix;
        private ObservableCollection<Composant> _vecteurComposant;

        public ObservableCollection<Composant> VecteurComposant
        {
            get{
                return _vecteurComposant;
            }

            set{
                if (_vecteurComposant != value)
                {
                    _vecteurComposant = value;
                }
            }
        }
        
        public string NomPc{
        get{return _nomPc; }

        set { _nomPc = NomPc; }
        }

        public string Image
        {
            get { return _image; }

            set { _image = Image; }
        }

        public DateTime Date
        {
            get { return _date; }

            set { _date = Date; }
        }

        public float Prix
        {
            get { return _prix; }

            set { _prix = Prix; }
        }

        public PC():this("Test", "url", new ObservableCollection<Composant>(), new DateTime(),0)
        {
        }

        public PC(string NomPc, string Image, ObservableCollection<Composant> VecteurComposant ,DateTime Date,float p)
        {
            _nomPc = NomPc;
            _image = Image;
            _vecteurComposant = VecteurComposant;
            _date = DateTime.Now;
            _prix = p;
        }
    }
}
