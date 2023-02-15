using org.mariuszgromada.math.mxparser;

namespace Genetic_algorithm
{
    static class Utils
    {
        public static Expression function;
        public static Argument xArg = new Argument("x", xArg);
        public static Argument yArg = new Argument("y", yArg);

        public static void ReInitializeFunction(string expression)
        {
            function = new Expression(expression, xArg, yArg);
        }

        public static double CalcFunc(double x, double y)
        {
            xArg.setArgumentValue(x); 
            yArg.setArgumentValue(y);
            return function.calculate();
        }

        public static double GetRandomDouble(double min, double max)
        {
            var rnd = new Random();
            return rnd.NextDouble() * (max - min) + min;
        }
    }
}