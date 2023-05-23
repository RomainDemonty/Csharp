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

        public PC():this("Test", "url", new ObservableCollection<Composant>(), new DateTime())
        {
        }

        public PC(string NomPc, string Image, ObservableCollection<Composant> VecteurComposant ,DateTime Date)
        {
            _nomPc = NomPc;
            _image = Image;
            _vecteurComposant = VecteurComposant;
            _date = DateTime.Now;
        }
    }
}
