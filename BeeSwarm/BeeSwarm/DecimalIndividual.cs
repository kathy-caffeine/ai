namespace BeeSwarm.Individual
{
    class DecimalIndividual
    {
        public (double x, double y)? Gens { get; set; }

        public DecimalIndividual((double x, double y)? gens)
        {
            Gens = gens;
        }
    }
}