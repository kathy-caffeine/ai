using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    internal class ALayer : Layer
    {
        double Epsilon;

        public ALayer (double epsilon = 0.25)
        {
            Epsilon = epsilon;
        }

        public override double[] FormOutputSignal(double[] input)
        {
            double[] outputSignal = input;

            do
            {
                input = (double[])outputSignal.Clone();

                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length; j++)
                        if (i != j)
                            outputSignal[i] += input[j];

                    outputSignal[i] *= (-Epsilon); // take into account negative feedback
                    outputSignal[i] += input[i]; // take into account connection between i and i neuron
                }

                outputSignal = signalConvert(outputSignal);

            } while (!areContainsSame(input, outputSignal));

            return outputSignal;
        }

        double[] signalConvert(double[] signal)
        {
            double[] outputSignal = new double[signal.Length];

            for (int i = 0; i < signal.Length; i++)
                outputSignal[i] = signal[i] > 0 ? signal[i] : 0;

            return outputSignal;
        }

        bool areContainsSame(double[] signal1, double[] signal2)
        {
            bool containsSame = true;

            for (int i = 0; i < signal1.Length; i++)
                if (signal1[i] != signal2[i])
                    return false;

            return containsSame;
        }
    }
}
