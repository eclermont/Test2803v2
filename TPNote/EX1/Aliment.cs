using System;
namespace Ex1
{
    public class Aliment
    {
        public string _nomAliment;
        public int _temperature;
        private DateTime _dateAchat;
        private DateTime _datePeremption;

        public Aliment(string nomAliment, DateTime dateAchat, DateTime datePeremption, int temperature)
        {
            this._nomAliment = nomAliment;
            this._dateAchat = dateAchat;
            this._datePeremption = datePeremption;
            this._temperature = temperature;
        }

        public override string ToString()
        {
            return "Un "+this._nomAliment+" acheté le "+this._dateAchat+ " et périmant le " + this._datePeremption+ ", conservé à " +this._temperature +
                " degrés."; 
        }
    }
}
