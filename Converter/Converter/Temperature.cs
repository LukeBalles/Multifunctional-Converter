using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Temperature
    {
        public float varNumb;

        public float celcius()
        {
            return (varNumb * 9/5) + 32;
        }

        public float fahreinheit()
        {
            return (varNumb - 32) * 5/9;
        }
    }
}
