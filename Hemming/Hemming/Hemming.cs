using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    internal class Hemming
    {
        SLayer s;
        ZLayer z;
        ALayer a;
        YLayer y;
        List<int[,]> samples;

        public Hemming(int amountOfSamples, int amountOfSignalNeurons, List<int[,]> samples, double epsilon)
        {
            s = new SLayer();
            z = new ZLayer(amountOfSignalNeurons, samples, epsilon);
            a = new ALayer(epsilon);
            y = new YLayer();
            this.samples = samples;
        }

        public List<int> mainHemming(int[,] inputSignal)
        {
            double[] zInput = z.FormInputSignal(s.GetOutputSignal(inputSignal));

            List<int> indexes = MaxElemIndex(zInput);
            if (indexes.Count > 1)
                return indexes;

            indexes = new List<int>();

            double[] zOutput = z.FormOutputSignal(zInput); 

            double[] aInput = (double[])zOutput.Clone();

            indexes = MaxElemIndex(aInput);
            if (indexes.Count == 1)
                return indexes;

            indexes = new List<int>();

            double[] yOutput = y.FormOutputSignal(a.FormOutputSignal(zOutput));

            for (int i = 0; i < yOutput.Length; i++)
                if (yOutput[i] == 1)
                    indexes.Add(i);

            return indexes;
        }

        List<int> MaxElemIndex(double[] array)
        {
            List<int> indexes = new List<int>();

            if (array.Length > 0)
            {
                double max = array.Max();

                for (int i = 0; i < array.Length; i++)
                    if (max == array[i])
                        indexes.Add(i);
            }

            return indexes;
        }
    }
}
