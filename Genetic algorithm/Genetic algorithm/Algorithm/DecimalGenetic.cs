using System.Diagnostics;
using Genetic_algorithm.Abstractions;
using Genetic_algorithm.Individual;

namespace Genetic_algorithm.Algorithm
{
    class DecimalGenetic : IGeneticAlgorithm
    {
        double XMin { get; init; }
        double XMax { get; init; }
        double YMin { get; init; }
        double YMax { get; init; }
        public int PopulationSize { get; }
        int MutationChance { get; init; }
        public int IterationCount { get; }
        private DecimalIndividual BestIndividual { get; set; }

        public DecimalGenetic(double xMin, double xMax, double yMin, double yMax,
            int populationSize, int mutationChance, int iterationCount)
        {
            XMin = xMin;
            XMax = xMax;
            YMin = yMin;
            YMax = yMax;
            PopulationSize = populationSize;
            MutationChance = mutationChance;
            IterationCount = iterationCount;
        }

        private DecimalIndividual CreateIndividual()
        {
            if (XMin > XMax) throw new ArgumentException("Нижняя граница x должна быть " +
                "меньше верхней границы x!");
            if (YMin > YMax) throw new ArgumentException("Нижняя граница y должна быть " +
                "меньше верхней границы y!");

            return new DecimalIndividual((
                Utils.GetRandomDouble(XMin, XMax),
                Utils.GetRandomDouble(YMin, YMax)));
        }

        private List<DecimalIndividual> CreatePopulation(int populationNumber)
        {
            var population = new List<DecimalIndividual>(populationNumber);
            for (int i = 0; i < populationNumber; i++)
            {
                population.Add(CreateIndividual());
            }
            return population;
        }

        private List<double> GetPopulationFitness(List<DecimalIndividual> individuals)
        {
            var fitnessList = new List<double>(individuals.Count);

            foreach (var individual in individuals)
            {
                fitnessList.Add(individual.Fitness());
            }

            return fitnessList;
        }

        private DecimalIndividual CrossIndividuals(DecimalIndividual firstIndividual, 
            DecimalIndividual secondIndividual) =>
            new DecimalIndividual((firstIndividual.Gens.Value.x, secondIndividual.Gens.Value.y));


        private List<DecimalIndividual> GetNewGeneration(List<DecimalIndividual> currentGeneration)
        {
            if (BestIndividual == null) BestIndividual = currentGeneration[0];

            var fitnessList = GetPopulationFitness(currentGeneration);

            var tempGeneration = TournamentSelection(currentGeneration, fitnessList);

            var newGeneration = CrossGeneration(tempGeneration);

            for (int i = 0; i < newGeneration.Count; i++)
            {
                newGeneration[i] = newGeneration[i].Mutate(MutationChance);
                if (BestIndividual.Fitness() < newGeneration[i].Fitness()) BestIndividual =
                        newGeneration[i].Clone();
            }

            return newGeneration;
        }

        private List<DecimalIndividual> TournamentSelection(List<DecimalIndividual> currentGeneration, 
            List<double> fitnessList)
        {
            var tempGeneration = new List<DecimalIndividual>(currentGeneration.Count);
            var rand = new Random();

            while (tempGeneration.Count < currentGeneration.Count)
            {
                var firstIndividualNumber = rand.Next(0, currentGeneration.Count);
                var secondIndividualNumber = rand.Next(0, currentGeneration.Count);
                var thirdIndividualNumber = rand.Next(0, currentGeneration.Count);

                // Достаем 3 случайных индивидуумов до момента, пока они не будут разными
                while (firstIndividualNumber == secondIndividualNumber ||
                    firstIndividualNumber == thirdIndividualNumber ||
                    secondIndividualNumber == thirdIndividualNumber)
                {
                    firstIndividualNumber = rand.Next(0, currentGeneration.Count);
                    secondIndividualNumber = rand.Next(0, currentGeneration.Count);
                    thirdIndividualNumber = rand.Next(0, currentGeneration.Count);
                }

                // Если первый индивидуум наиболее приспособлен, добавляем его
                if (fitnessList[firstIndividualNumber] > fitnessList[secondIndividualNumber] &&
                    fitnessList[firstIndividualNumber] > fitnessList[thirdIndividualNumber])
                    tempGeneration.Add(currentGeneration[firstIndividualNumber]);
                // Если второй индивидуум наиболее приспособлен, добавляем его
                else if (fitnessList[secondIndividualNumber] > fitnessList[firstIndividualNumber] &&
                    fitnessList[secondIndividualNumber] > fitnessList[thirdIndividualNumber])
                    tempGeneration.Add(currentGeneration[secondIndividualNumber]);
                // Если третий индивидуум наиболее приспособлен, добавляем его
                else tempGeneration.Add(currentGeneration[thirdIndividualNumber]);
            }

            return tempGeneration;
        }

        private List<DecimalIndividual> CrossGeneration(List<DecimalIndividual> tempGeneration)
        {
            var newGeneration = new List<DecimalIndividual>(tempGeneration.Count);
            var rand = new Random();

            while (newGeneration.Count < tempGeneration.Count)
                newGeneration.Add(
                    CrossIndividuals(
                        tempGeneration[rand.Next(0, tempGeneration.Count)],
                        tempGeneration[rand.Next(0, tempGeneration.Count)]));
            return newGeneration;
        }

        public DecimalIndividual FindFunctionMinimum()
        {
            List<DecimalIndividual> currentGen = CreatePopulation(PopulationSize);

            List<DecimalIndividual> newGen = currentGen;

            for (int i = 0; i < IterationCount; i++)
            {
                currentGen = newGen;
                newGen = GetNewGeneration(currentGen);
                Debug.Print($"({BestIndividual.Gens.Value.x}; {BestIndividual.Gens.Value.y}) = " +
                    $"{BestIndividual.Fitness()}");
            }
            return BestIndividual;
        }
    }
}