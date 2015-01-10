using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Maths m = new Maths();
            while (true)
            {
                Console.WriteLine(m.Add(2, 3));
            }
        }
    }
}
