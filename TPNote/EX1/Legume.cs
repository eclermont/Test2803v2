using System;
namespace Ex1
{
    public class Legume : Aliment
    {
        private int _nbVitamines { get; set; }

        public Legume(DateTime date1, DateTime date2, int nbVitamines) : base("legume", date1, date2, 8)
        {
            this._nbVitamines = nbVitamines;
        }
        public override string ToString()
        {
            string chres = base.ToString();
            chres += "Avec un apport de " + this._nbVitamines + " vitamines. ";
            return chres;
        }
    }
}
