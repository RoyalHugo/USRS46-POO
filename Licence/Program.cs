using System;

namespace POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Maison UneMaison = new Maison("11 Rue des Chartreux, 69001 Lyon", 58f, 4, false);
            Maison UneAutreMaison = new Maison("4 place Saint Louis, 22100 Dinan", 86.5f, 5, true);
            Maison UneDerniereMaison = new Maison("26 Boulevard Claude Lorrin, 40100 Dax", 25.2f, 2, false);

            Terrain terrain1 = new Terrain("113 Avenue de France, Paris", 10, 6, false);
            Terrain terrain2 = new Terrain("108 Boulevard Haussmann, Toulouse", 39, 4, false);
            Terrain terrain3 = new Terrain("8 Rue Clement, Lyon", 28, 2, false);

            Bien[] CatalogueBiens = [UneMaison, UneAutreMaison, UneDerniereMaison, terrain1, terrain2, terrain3];

            foreach (Bien bien in CatalogueBiens)
            {
                Console.WriteLine(bien);
            }

            Proprietaire Mark = new Proprietaire("Malaka", "Mark", new Bien[] { UneMaison, terrain1});
            Console.WriteLine(Mark);
        }
    }
}
