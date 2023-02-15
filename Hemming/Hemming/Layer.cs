using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    internal abstract class Layer: IInputNeuronSignal, INeuronSignal
    {
        public virtual double[] FormInputSignal(double[] input)
        {
            return input;
        }

        public virtual double[] FormOutputSignal(double[] input)
        {
            return input;
        }

        public double[] GetOutputSignal(int[,] inputSignal)
        {
            return FormOutputSignal(FormInputSignal(Converters.DoubleArray(inputSignal)));
        }

    }
}
