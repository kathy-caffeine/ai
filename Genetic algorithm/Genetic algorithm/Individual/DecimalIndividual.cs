namespace Genetic_algorithm.Individual
{
    class DecimalIndividual
    {
        public (double x, double y)? Gens { get; set; }

        public DecimalIndividual((double x, double y)? gens)
        {
            Gens = gens;
        }

        public double Fitness()
        {
            if (!Gens.HasValue) throw new ArgumentNullException();

            return -1 * Utils.CalcFunc(Gens.Value.x, Gens.Value.y);
        }

        public DecimalIndividual Clone()
        {
            return new DecimalIndividual((Gens.Value.x, Gens.Value.y));
        }

        public DecimalIndividual Mutate(int chance)
        {
            var rnd = new Random();

            // Мутация не произошла
            var rndRes = rnd.NextDouble();
            if (rndRes >= (double)chance / 100)
                return this;

            var mutated = Clone();

            var xImpact = rnd.NextDouble() - 0.5;
            var yImpact = rnd.NextDouble() - 0.5;

            mutated.Gens = (mutated.Gens.Value.x + xImpact, mutated.Gens.Value.y + yImpact);

            return mutated;
        }
    }
}