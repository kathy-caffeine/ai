using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    internal interface IInputNeuronSignal
    {
        public abstract double[] FormInputSignal(double[] input);
    }
}
