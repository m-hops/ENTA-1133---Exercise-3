using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class DieRoller
    {
        public void Roll()
        {
            Random RNG = new Random();
            int D4 = RNG.Next(1,5);
            int D6 = RNG.Next(1, 7);
            int D10 = RNG.Next(1, 11);
            int D20 = RNG.Next(1, 21);

            int total = D4 + D6 + D10 + D20;

            Console.WriteLine("Roll Results:");
            Console.WriteLine("D4 = " + D4);
            Console.WriteLine("D6 = " + D6);
            Console.WriteLine("D10 = " + D10);
            Console.WriteLine("D20 = " + D20);

            Console.WriteLine("Your final score is " + total);

        }
    }
}
