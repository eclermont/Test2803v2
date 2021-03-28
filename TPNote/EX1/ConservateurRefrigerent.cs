using System;
using System.Collections.Generic;

namespace Ex1
{
    public abstract class ConservateurRefrigerent
    {
        private String _marque;
        private int _prix;
        protected List<Aliment> _contenu;
        private int _capacite; 

        public ConservateurRefrigerent(string marque, int prix, List<Aliment> contenu, int capacite)
        {
            this._marque = marque;
            this._prix = prix;
            this._contenu = contenu;
            this._capacite = capacite; 
        }

        public void AjouterAliment(Aliment a)
        {
            if(_contenu.Count<_capacite)
            {
                _contenu.Add(a);
            }
            else
            {
                Console.WriteLine("Il n'y a plus de place pour ajouter un aliment dans le frigo.");
            }
        }

        public void EnleverAliment(Aliment a)
        {
            if(_contenu.Count != 0)
            {
                _contenu.Remove(a);
            }
            else
            {
                Console.WriteLine("Votre frigo est déjà vide...");
            }
        }

        public override string ToString()
        {
            string chres = "Je suis un produit électroménager permettant la conservation des données de marque " +
                this._marque + ", j'ai la capacité de stocker  "+this._capacite+" éléments, et je coûte "+this._prix+" euros.";
            return chres;
        }

        public abstract void Refroidir();

    }

}
