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
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}
