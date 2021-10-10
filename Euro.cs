using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD
{
    internal class Euro : USD
    {
        public double e;
        public Euro(double a) : base(a)
        {
            e = a * 0.86;
        }


        public override string? ToString()
        {
            return e.ToString();
        }
    }
}
