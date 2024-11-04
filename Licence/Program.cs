using System;

namespace POO
{
    public class Terrain
    {
        public string Adresse;
        public float Superficie;
        public int NbCotesCloture;
        public bool Riviere;

        // Constructeur
        public Terrain(string adresse, float superficie, int nbcotescloture, bool riviere)
        {
            this.Adresse = adresse;
            this.Superficie = superficie;
            this.NbCotesCloture = nbcotescloture;
            this.Riviere = riviere;
        }

        // ToString
        public override string ToString()
        {
            string toString = String.Format("Adresse: {0}\n", this.Adresse);
            toString += String.Format("Superficie: {0}m²\n", this.Superficie);
            toString += String.Format("Nombre de clotures: {0}\n", this.NbCotesCloture);
            toString += String.Format("Rivière?: {0}", this.Riviere ? "Oui" : "Non");
            return toString;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
