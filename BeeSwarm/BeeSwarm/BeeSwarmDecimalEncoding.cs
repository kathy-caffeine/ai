using System.Diagnostics;
using System.Drawing;
using BeeSwarm.Individual;

namespace BeeSwarm.Algorithm
{
    class BeeSwarm : IBeeSwarm
    {
        double XMin { get; init; }
        double XMax { get; init; }
        double YMin { get; init; }
        double YMax { get; init; }
        public int PopulationSize { get; }
        public int IterationCount { get; }
        int PointsToCheckCount { get; init; }
        int PointsEliteCount { get; init; }
        int BeeCountPointsToCheck { get; init; }
        int BeeCountPointsElite { get; init; }
        double NeighborhoodSize { get; init; }
        double Accuracy = 1e-5;
        private DecimalIndividual BestIndividual { get; set; }

        public BeeSwarm(
            double xMin,
            double xMax,
            double yMin,
            double yMax,
            int populationSize,
            int iterationCount,
            int pointsToCheckCount,
            double neighborhoodSize = 1,
            int pointsEliteCount = 15,
            int beeCountPointsToCheck = 75,
            int beeCountPointsElite = 25
        )
        {
            XMin = xMin;
            XMax = xMax;
            YMin = yMin;
            YMax = yMax;
            PopulationSize = populationSize;
            IterationCount = iterationCount;
            PointsToCheckCount = pointsToCheckCount;
            PointsEliteCount = pointsEliteCount;
            BeeCountPointsToCheck = beeCountPointsToCheck;
            BeeCountPointsElite = beeCountPointsElite;
            NeighborhoodSize = neighborhoodSize;
        }

        private DecimalIndividual CreateIndividual()
        {
            return new DecimalIndividual((
                Utils.GetRandomDouble(XMin, XMax),
                Utils.GetRandomDouble(YMin, YMax))
            );
        }

        private List<DecimalIndividual> CreatePopulation()
        {
            var population = new List<DecimalIndividual>(PopulationSize);
            for (int i = 0; i < PopulationSize; i++)
            {
                population.Add(CreateIndividual());
            }
            return population;
        }

        private List<DecimalIndividual> SortPopulation(List<DecimalIndividual> population)
        {
            population.Sort((p1, p2) => {
                return Math.Abs(Utils.CalcFunc(p1.Gens.Value.x, p1.Gens.Value.y)).CompareTo(
                        Math.Abs(Utils.CalcFunc(p2.Gens.Value.x, p2.Gens.Value.y)));
            });
            BestIndividual = population[0];
            return population;
        }

        private List<DecimalIndividual> LocalSearch(List<DecimalIndividual> population)
        {
            for (int i = 0; i < PointsToCheckCount; i++)
            {
                population[i] = LocalSearchForIndividual(population[i], i > PointsEliteCount);
            }

            return population;
        }

        private DecimalIndividual LocalSearchForIndividual(DecimalIndividual individual, bool isElite)
        {
            var localWinner = individual;
            for (int j = 0; j < (isElite ? BeeCountPointsElite : BeeCountPointsToCheck); j++)
            {
                var randomLocal = new DecimalIndividual((
                    Utils.GetRandomDouble(individual.Gens.Value.x - NeighborhoodSize, individual.Gens.Value.x + NeighborhoodSize),
                    Utils.GetRandomDouble(individual.Gens.Value.y - NeighborhoodSize, individual.Gens.Value.y + NeighborhoodSize)
                ));
                if (
                    IsInBounds(randomLocal) &&
                    Math.Abs(Utils.CalcFunc(randomLocal.Gens.Value.x, randomLocal.Gens.Value.y)) < 
                    Math.Abs(Utils.CalcFunc(individual.Gens.Value.x, individual.Gens.Value.y))
                )
                {
                    localWinner = randomLocal;
                }
            }

            return localWinner;
        }

        private bool AccuracyAchieved(List<DecimalIndividual> generation)
        {
            return Math.Abs(
                Utils.CalcFunc(generation[1].Gens.Value.x, generation[1].Gens.Value.y) -
                Utils.CalcFunc(generation[0].Gens.Value.x, generation[0].Gens.Value.y)
            ) < Accuracy;
        }

        private bool IsInBounds(DecimalIndividual individual)
        {
            return individual.Gens.Value.x >= XMin && individual.Gens.Value.x <= XMax
                    && individual.Gens.Value.y >= YMin && individual.Gens.Value.y <= YMax;
        }

        public DecimalIndividual FindFunctionMinimum()
        {
            // Создаём популяцию
            var generation = CreatePopulation();

            int i;
            for (i = 0; i < IterationCount; i++)
            {
                // Сортируем популяцию
                generation = SortPopulation(generation);

                // Заканчиваем, если точность достигнута
                if (AccuracyAchieved(generation)) break;

                // Локальный поиск для исследуемых точек
                generation = LocalSearch(generation);

                // Случайный поиск для оставшихся точек
                for (int j = PointsToCheckCount; j < PopulationSize; j++)
                {
                    generation[j] = CreateIndividual();
                }
            }
            // Сортируем популяцию
            SortPopulation(generation);
            // Выводим число итераций
            Debug.WriteLine(i);
            return BestIndividual;
        }
    }
}