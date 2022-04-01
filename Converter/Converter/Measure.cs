using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Measure
    {
        public float varNumb;
        public float centimeters()
        {
            return varNumb / 100;
        }

        public float meters()
        {
            return varNumb * 100;
        }
    }
}
