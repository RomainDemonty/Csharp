using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [Serializable]
    public class Conteneur
    {
        private static Conteneur _allConteneur;

        //Biding
        private Composant selected_compo;
        private PC selected_pc;

        private ObservableCollection<Personne> _vecPersonnes;
        private ObservableCollection<PC> _vecPcs;
        private ObservableCollection<Composant> _vecComposants;

        //Constructeur des vecteurs
        public Conteneur()
        {
            _vecPersonnes = new ObservableCollection<Personne>();
            _vecComposants = new ObservableCollection<Composant>();
            _vecPcs = new ObservableCollection<PC>();

            //Si je veux rajouter des éléments par défault c'est ici
        }

        public static Conteneur GetAllConteneur()
        {
            if (_allConteneur == null)
            {
                if (File.Exists("Donnees"))
                {
                    _allConteneur = Serializer.DeserializeJson("Donnees");
                }
                else
                {
                    _allConteneur = new Conteneur();
                }
            }
            return _allConteneur;
        }

        public Composant SelectedCompo
        {
            get { return selected_compo; }
            set { selected_compo = value; }
        }
        public PC SelectedPC
        {
            get { return selected_pc; }
            set { selected_pc = value; }
        }

        public ObservableCollection<Personne> VecPersonnes
        {
            get { return _vecPersonnes; }
            set { _vecPersonnes = value; }
        }
        public ObservableCollection<PC> VecPcs
        {
            get { return _vecPcs; }
            set { _vecPcs = value; }
        }
        public ObservableCollection<Composant> VecComposants
        {
            get { return _vecComposants; }
            set { _vecComposants = value; }
        }

        //Les méthodes d'ajout
        public void AjouterCompo(Composant C)
        {
            _vecComposants.Add((Composant)C);
        }
        public void AjouterPC(PC P)
        {
            _vecPcs.Add((PC)P);
        }
        public void AjouterPer(Personne P)
        {
            _vecPersonnes.Add((Personne)P);
        }

        //Suppression d'un élément
        public void SuppressionPC(PC P)
        {
            int index;
            index = Conteneur.GetAllConteneur()._vecPcs.IndexOf(selected_pc);
            return;
        }
        public void SuppressionComp(Composant C)
        {
            int index;
            index = Conteneur.GetAllConteneur()._vecComposants.IndexOf(selected_compo);
            return;
        }

        //Si éjà présent
        public int VerifPer(Personne P)
        {
            int res = 0;
            foreach (Personne Test in _vecPersonnes)
            {
                if (P.Nom == Test.Nom)
                {
                    res = 1;
                    return res;
                }
                else
                {
                    if (P.motDePasse == Test.motDePasse)
                    {
                        res = 2;
                        return res;
                    }
                    else
                    {
                        res = 0;
                        return res;
                    }
                }
            }

            return res;
        }

    }
}
