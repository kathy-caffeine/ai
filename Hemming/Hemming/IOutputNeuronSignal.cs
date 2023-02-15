using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    internal interface INeuronSignal
    {
        public abstract double[] FormOutputSignal(double[] input);
    }
}
