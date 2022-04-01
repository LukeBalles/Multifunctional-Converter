using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    internal class Money
    {
        public float varNumb;

        public float reais()
        {
            return varNumb * 0.2109f;
        }

        public float dollar()
        {
            return varNumb * 4.74f;
        }
    }
}
