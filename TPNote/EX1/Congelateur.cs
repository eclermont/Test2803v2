using System;
using System.Collections.Generic;

namespace Ex1
{
    public class Congelateur : ConservateurRefrigerent
    {
        public Congelateur(string marque, int prix, List<Aliment> contenu, int capacite) : base(marque, prix, contenu, capacite)
        {
        }

        public override void Refroidir()
        {
            for (int i = 0; i < _contenu.Count; i++)
            {
                _contenu[i]._temperature += -15;
            }
        }

        public override string ToString()
        {
            string chres = base.ToString();
            chres += "Plus spécifiquement je suis un congélateur. Je possède " + this._contenu.Count + " élements : ";
            for (int i = 0; i < _contenu.Count; i++)
            {
                chres += _contenu[i].ToString() + "\n";
            }
            return chres;
        }
    }
}
