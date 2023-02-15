using Genetic_algorithm.Individual;

namespace Genetic_algorithm.Abstractions
{
    internal interface IGeneticAlgorithm
    {
        public DecimalIndividual FindFunctionMinimum();
    }
}
