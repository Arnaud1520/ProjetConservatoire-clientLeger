using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connecte.Modele
{
    public class Professeur : Personne
    {
        private string instrument;
        private double salaire;

        public string Instrument { get => instrument; set => instrument = value; }
        public double Salaire { get => salaire; set => salaire = value; }

        public Professeur(int unId, string unNom, string unPrenom, string unTel, string unMail, string uneAdresse, string unInstrument, double unSalaire) : base(unId, unNom, unPrenom, unTel, unMail, uneAdresse)
        {
            this.instrument = unInstrument;
            this.salaire = unSalaire;
        }

        public override string Description
        {
            get => base.Description + " instrument : " + this.instrument + " salaire : " + this.salaire;
        }

    }
}
