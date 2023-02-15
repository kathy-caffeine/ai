using System.Collections;

namespace Genetic_algorithm.Individual
{
    internal class BinaryIndividual
    {
        public (double x, double y)? Gens { get; private set; }
        public BinaryIndividual((double x, double y)? gens)
        {
            Gens = gens;
        }

        public double Fitness()
        {
            if (!Gens.HasValue) throw new ArgumentNullException();

            return -1 * Utils.CalcFunc(Gens.Value.x, Gens.Value.y);
        }

        public BinaryIndividual Clone()
        {
            return new BinaryIndividual((Gens.Value.x, Gens.Value.y));
        }

        public BinaryIndividual Mutate(int chance)
        {
            var rand = new Random();

            // Мутация не произошла
            if (rand.NextDouble() >= (double)chance / 100)
                return this;

            var mutated = Clone();

            var intrand = new Random();
            var p = intrand.Next();

            var x = (Convert.ToInt32(Gens.Value.x) ^ p) -
                Convert.ToInt32(Gens.Value.x) + Gens.Value.x;
            p = intrand.Next();
            var y = (Convert.ToInt32(Gens.Value.x) ^ p) -
                Convert.ToInt32(Gens.Value.x) + Gens.Value.x;

            mutated.Gens = (x, y);

            return mutated;
        }
    }
}