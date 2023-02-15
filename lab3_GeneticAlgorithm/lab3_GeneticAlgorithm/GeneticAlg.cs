using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_GeneticAlgorithm
{
    class GeneticAlg
    {
        public List<Chromosome> current;
        public List<Chromosome> next;
        public List<Chromosome> bestIterations;

        private Params.FunctionForAlg function;
        private Params @params;
        private int pSize;
        private double totalFit;
        private List<double> functionAnswers;

        public GeneticAlg(Params par)
        {
            @params = par;
            pSize = par.populationSize;

            function = new Params.FunctionForAlg(Params.testFunc);
        }

        public void Run()
        {
            current = new List<Chromosome>();
            next = new List<Chromosome>();
            functionAnswers = new List<double>();
            bestIterations = new List<Chromosome>();

            CreateFirst();
            RankCurrrent();
            bestIterations.Add(current[current.Count - 1]);

            for (int i = 0; i < @params.interations; i++)
            {
                CreateNext();
                RankCurrrent();
                bestIterations.Add(current[current.Count - 1]);
            }
        }

        private void CreateFirst()
        {
            for (int i = 0; i < pSize; i++)
            {
                Chromosome g = new Chromosome(@params.chromosomeSize, @params.mutationProbability);
                current.Add(g);
            }
        }

        private void RankCurrrent()
        {
            totalFit = 0;
            for (int i = 0; i < pSize; i++)
            {
                Chromosome g = current[i];
                g.functionAnswer = function(g.genes);
                totalFit += 1 / g.functionAnswer;
            }
            current.OrderByDescending(x => x.functionAnswer);

            double fitness = 0.0;
            functionAnswers.Clear();
            for (int i = 0; i < pSize; i++)
            {
                fitness += 1 / current[i].functionAnswer;
                functionAnswers.Add(fitness);
            }
        }

        private void CreateNext()
        {
            next.Clear();

            for (int i = 0; i < pSize; i += 2)
            {
                Chromosome parent1, parent2, child1, child2;
                parent1 = SelectParent();
                parent2 = SelectParent();

                if (Params.random.NextDouble() < @params.crossoverProbability)
                { 
                    parent1.Crossover(parent2, out child1, out child2); 
                }
                else
                {
                    child1 = parent1;
                    child2 = parent2;
                }
                child1.Mutate(@params.flag);
                child2.Mutate(@params.flag);
                next.Add(child1);
                next.Add(child2);
            }

            current.Clear();
            for (int i = 0; i < pSize; i++)
                current.Add(next[i]);
        }

        private Chromosome SelectParent()
        {
            Chromosome selected = null;
            double randomFunctionAnswer = Params.random.NextDouble() * totalFit;
            int left = 0, right = pSize - 1;
            int mid = (right - left) / 2;

            while (selected == null && left <= right)
            {
                if (randomFunctionAnswer < functionAnswers[mid])
                    right = mid; 
                else if (randomFunctionAnswer > functionAnswers[mid])
                    left = mid; 
                mid = (left + right) / 2;
                if ((right - left) == 1) selected = current[right];
            }
            return selected;
        }

        public Chromosome GetAnswer() => current[current.Count -1];
    }
}
