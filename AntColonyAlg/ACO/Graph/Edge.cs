using System;

namespace AntColony.GraphNamespace
{
    public class Edge
    {
        public int StartVertex { get; set; }
        public int FinishVertex { get; set; }
        public double Length { get; set; }
        public double Pheromone { get; set; }
        public double Weight { get; set; }

        public Edge() { }

        public Edge(int start, int end, int length)
        {
            StartVertex = start;
            FinishVertex = end;
            Length = length;
        }
    }
}
