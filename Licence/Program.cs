﻿using System;

namespace POO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Terrain terrain1 = new Terrain("113 Avenue de France, Paris", 50, 6, false);
            Terrain terrain2 = new Terrain("108 Boulevard Haussmann, Toulouse", 50, 6, false);
            Terrain terrain3 = new Terrain("8 Rue Clement, Lyon", 50, 6, false);

            Terrain[] allterrains = { terrain1, terrain2, terrain3 };

            foreach (Terrain terrain in allterrains)
            {
                Console.WriteLine(terrain);
            }
        }
    }
}
