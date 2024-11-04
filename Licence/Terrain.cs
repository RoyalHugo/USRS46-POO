using System;
using System.Text.RegularExpressions;

namespace POO
{
	public class Terrain :  Bien
	{
        public int NbCotesCloture;
        public bool Riviere;

        // Constructeur
        public Terrain(string adresse, float superficie, int nbcotescloture, bool riviere) : base(adresse, superficie)
        {
            this.NbCotesCloture = nbcotescloture;
            this.Riviere = riviere;
        }

        // ToString
        public override string ToString()
        {
            string toString = String.Format("Nombre de clotures clorutés: {0}\n", this.NbCotesCloture);
            toString += String.Format("Rivière?: {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("## VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }
        public new float EvaluationValeur()
        {
            int valeur = 3000;
            if (this.Riviere) { valeur += 500; };
            valeur += this.NbCotesCloture * 80;

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { valeur += 8000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { valeur += 2000; }

            return this.Superficie * valeur;

        }
    }
}
