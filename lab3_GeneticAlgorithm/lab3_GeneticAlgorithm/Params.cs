using NCalc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_GeneticAlgorithm
{
    public class Params
    {
        public static int lowerThreshold = -10;
        public static int upperThreshold = -5;
        public delegate double FunctionForAlg(double[] x);

        public double crossoverProbability = 0.65;
        public double mutationProbability = 0.65;
        public int populationSize = 100;
        public int interations = 2000;
        public int chromosomeSize = 2; 

        public static Random random;
        static Expression exp;

        public bool flag;
        public Params(double crossoverProbability, double mutationProbability, 
            int populationSize, int interations, string func, bool flag)
        {
            this.crossoverProbability = crossoverProbability;
            this.mutationProbability = mutationProbability;
            this.populationSize = populationSize;
            this.interations = interations;
            exp = new Expression(func);
            chromosomeSize = 2;
            random = new Random();
            this.flag = flag;
        }

        public static double testFunc(double[] x)
        {
            exp.Parameters["x"] = x[0];
            exp.Parameters["y"] = x[1];

            return (double)exp.Evaluate();
        }

    }
}
