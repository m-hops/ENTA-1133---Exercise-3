using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GameManager manager = new GameManager();
            Console.WriteLine("Welcome to Madeline's Dice Roll Generator");
            Console.WriteLine("19-09-2024");
            Console.WriteLine("---");
            manager.Play();
            Console.WriteLine("---");
            Console.WriteLine("+ means find the sum");
            Console.WriteLine("- means find the difference");
            Console.WriteLine("/ means division");
            Console.WriteLine("* means multiplication");
            Console.WriteLine("++ means to increase the value by 1");
            Console.WriteLine("-- means to decrease the value by 1");
            Console.WriteLine("% retuns the remainder of two values");
            Console.WriteLine("---");
            Console.WriteLine("Goodbye </3");
            Console.ReadLine();
        }
    }
}
