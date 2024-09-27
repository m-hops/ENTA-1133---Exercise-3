using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DieRoller
    {
        public int Roll(int maxVal)
        {
            Random RNG = new Random();
            int rollVal = RNG.Next(1,maxVal+1);
            return rollVal;

        }
    }
}
