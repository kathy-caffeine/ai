using System.Collections;
using System.Diagnostics;
using Genetic_algorithm.Abstractions;
using Genetic_algorithm.Individual;

namespace Genetic_algorithm.Algorithm
{
    internal class BinaryGenetic : IGeneticAlgorithm
    {
        private double XMin { get; init; }
        private double XMax { get; init; }
        private double YMin { get; init; }
        private double YMax { get; init; }
        private int PopulationSize { get; }
        private int MutationChance { get; init; }
        private int IterationCount { get; }
        private BinaryIndividual BestIndividual { get; set; }
        private int CountOfBits { get; } = 8;

        public BinaryGenetic(double xMin, double xMax, double yMin, double yMax, 
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

        private BinaryIndividual CreateIndividual()
        {
            if (XMin > XMax) throw new ArgumentException("Нижняя граница x " +
                "должна быть меньше верхней границы x!");
            if (YMin > YMax) throw new ArgumentException("Нижняя граница y " +
                "должна быть меньше верхней границы y!");

            return new BinaryIndividual((
                Utils.GetRandomDouble(XMin, XMax),
                Utils.GetRandomDouble(YMin, YMax)));
        }

        private List<BinaryIndividual> CreatePopulation(int populationNumber)
        {
            var population = new List<BinaryIndividual>(populationNumber);
            for (int i = 0; i < populationNumber; i++)
            {
                population.Add(CreateIndividual());
            }
            return population;
        }

        private List<double> GetPopulationFitness(List<BinaryIndividual> individuals)
        {
            var fitnessList = new List<double>(individuals.Count);

            foreach (var individual in individuals)
            {
                fitnessList.Add(individual.Fitness());
            }

            return fitnessList;
        }

        private BinaryIndividual CrossIndividuals(BinaryIndividual firstIndividual, 
            BinaryIndividual secondIndividual)
        {
            var crossedXGens = CrossGens(firstIndividual.Gens.Value.x, 
                secondIndividual.Gens.Value.x);
            var crossedYGens = CrossGens(firstIndividual.Gens.Value.y,
                secondIndividual.Gens.Value.y);

            var crossedIndividual = new BinaryIndividual((crossedXGens, crossedYGens));

            return crossedIndividual;
        }

        // Скрещивание генов первого и второго индивидуума

        private double CrossGens(double a1, double a2)
        {
            var rand = new Random();
            if (rand.Next() % 2 == 0)
            {
                return Convert.ToInt32(a2) - Convert.ToInt32(a1) + a1;
            }
            else
            {
                return Convert.ToInt32(a1) - Convert.ToInt32(a2) + a2;
            }
        }

        private static List<int> CalculateCrossingOverPoints(int genLength, Random rand, 
            int crossingOverPointCount, int byteLength)
        {
            List<int> crossingOverPoints = new List<int>();
            // Генерируем точки разрыва для каждого байта (хромосомы) в размере двух единиц
            for (int genByte = 0; genByte < genLength / byteLength; genByte++)
            {
                var firstPointIndex = rand.Next(0, byteLength);
                var secondPointIndex = rand.Next(0, byteLength);

                while (firstPointIndex == secondPointIndex)
                    secondPointIndex = rand.Next(0, byteLength);

                // Сортируем в порядке возрастания
                if (firstPointIndex > secondPointIndex)
                    (firstPointIndex, secondPointIndex) = (secondPointIndex, firstPointIndex);

                crossingOverPoints.Add(firstPointIndex + genByte * byteLength);
                crossingOverPoints.Add(secondPointIndex + genByte * byteLength);
            }

            return crossingOverPoints;
        }

        private List<BinaryIndividual> GetNewGeneration(List<BinaryIndividual> currentGeneration)
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

        private List<BinaryIndividual> TournamentSelection(List<BinaryIndividual> currentGeneration, 
            List<double> fitnessList)
        {
            var tempGeneration = new List<BinaryIndividual>(currentGeneration.Count);
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

        private List<BinaryIndividual> CrossGeneration(List<BinaryIndividual> tempGeneration)
        {
            var newGeneration = new List<BinaryIndividual>(tempGeneration.Count);
            var rand = new Random();

            while (newGeneration.Count < tempGeneration.Count)
            {
                var firstIndividualIndex = rand.Next(0, tempGeneration.Count);
                var secondIndividualIndex = rand.Next(0, tempGeneration.Count);

                while (firstIndividualIndex == secondIndividualIndex)
                    secondIndividualIndex = rand.Next(0, tempGeneration.Count);

                newGeneration.Add(
                CrossIndividuals(
                    tempGeneration[firstIndividualIndex],
                    tempGeneration[secondIndividualIndex]));
            }

            return newGeneration;
        }

        public DecimalIndividual FindFunctionMinimum()
        {
            List<BinaryIndividual> currentGen = CreatePopulation(PopulationSize);

            List<BinaryIndividual> newGen = currentGen;

            for (int i = 0; i < IterationCount; i++)
            {
                currentGen = newGen;
                newGen = GetNewGeneration(currentGen);
                Debug.Print($"({BestIndividual.Gens.Value.x}; {BestIndividual.Gens.Value.y}) = " +
                    $"{BestIndividual.Fitness()}");
            }
            return new DecimalIndividual((BestIndividual.Gens.Value.x, BestIndividual.Gens.Value.y));
        }
    }
}
