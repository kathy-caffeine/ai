using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_GeneticAlgorithm
{
    public class Chromosome
    {
        public double[] genes;
        public double functionAnswer;
        
        private double _mutationProbability;

        public Chromosome(int length, double mutationProbability, bool createGenes = true)
        {
            _mutationProbability = mutationProbability;
            genes = new double[length];
            for (int i = 0; i < length; i++)
                genes[i] = (Params.random.NextDouble()) * Params.upperThreshold;
        }


        public void Crossover(Chromosome Chromosome2, out Chromosome child1, out Chromosome child2)
        {
            int position = (int)(Params.random.NextDouble() * genes.Length);
            child1 = new Chromosome(genes.Length, _mutationProbability, false);
            child2 = new Chromosome(genes.Length, _mutationProbability, false);
            for (int i = 0; i < genes.Length; i++)
            {
                if (i < position)
                {
                    child1.genes[i] = genes[i];
                    child2.genes[i] = Chromosome2.genes[i];
                }
                else
                {
                    child1.genes[i] = Chromosome2.genes[i];
                    child2.genes[i] = genes[i];
                }
            }
        }

        public void Crossover(Chromosome Chromosome2, 
            out Chromosome child1, out Chromosome child2, bool flag)
        {
            if (flag)
            {
                int position = (int)(Params.random.NextDouble() * genes.Length);
                child1 = new Chromosome(genes.Length, _mutationProbability, false);
                child2 = new Chromosome(genes.Length, _mutationProbability, false);
                for (int i = 0; i < genes.Length; i++)
                {
                    if (i < position)
                    {
                        child1.genes[i] = genes[i];
                        child2.genes[i] = Chromosome2.genes[i];
                    }
                    else
                    {
                        child1.genes[i] = Chromosome2.genes[i];
                        child2.genes[i] = genes[i];
                    }
                }
            }
            else
            {
                Random random = new Random();
                int crunch = random.Next();
                int shit;
                int position = (int)(Params.random.NextDouble() * genes.Length);
                child1 = new Chromosome(genes.Length, _mutationProbability, false);
                child2 = new Chromosome(genes.Length, _mutationProbability, false);
                for (int i = 0; i < genes.Length; i++)
                {
                    try
                    {
                        shit = Convert.ToInt32(child1.genes[i]);
                    }
                    catch
                    {
                        shit = random.Next();
                    }
                    crunch = crunch ^ shit;
                    if (i < position)
                    {
                        child1.genes[i] = genes[i];
                        child2.genes[i] = Chromosome2.genes[i] - crunch;
                    }
                    else
                    {
                        child1.genes[i] = Chromosome2.genes[i];
                        child2.genes[i] = genes[i] + crunch;
                    }
                    crunch = random.Next();
                }
            }
        }

        public void Mutate(bool flag)
        {
            if (flag)
            {
                for (int position = 0; position < genes.Length; position++)
                {
                    var x = Params.random.Next(0, 2) == 0 ? 1 : -1;
                    if (genes[position] < Params.lowerThreshold) x = 1;
                    if (Params.random.NextDouble() < _mutationProbability)
                        genes[position] = (genes[position] + x * Params.random.NextDouble());
                }
            }
            else
            {
                Random random = new Random();
                int crunch = random.Next();
                int shit;
                for (int position = 0; position < genes.Length; position++)
                {
                    if (Params.random.NextDouble() < _mutationProbability)
                    {
                        try
                        {
                            shit = Convert.ToInt32(genes[position]);
                        }
                        catch
                        {
                            shit = random.Next();
                        }
                        crunch = shit ^ crunch;
                        genes[position] = ((genes[position] - shit + crunch) + Params.random.NextDouble());
                        crunch = random.Next();
                    }
                }
            }
        }
    }
}
