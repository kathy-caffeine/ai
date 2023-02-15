using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Annealing annealing = new Annealing();
            annealing.FilePath = "Cities.txt";
            annealing.Anneal();

            string path = "";
            for (int i = 0; i < annealing.CitiesOrder.Count - 1; i++)
            {
                path += annealing.CitiesOrder[i] + " -> ";
            }
            path += annealing.CitiesOrder[annealing.CitiesOrder.Count - 1];

            Console.WriteLine("Shortest Route: " + path);

            Console.WriteLine("The shortest distance is: " + annealing.ShortestDistance.ToString());

            Console.ReadLine();
        }
    }
}
