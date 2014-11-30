using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(new List<int> () {10, 20, 40}); // we are passing the list of integers
            Console.ReadLine();
        }
    }

    public class Calculator
    {
        [Obsolete("Use Add (List<int> Number) method instead", true)] // this give information that this method is obsolete, here true is optional and if we put false, it will give error if I try to call this method
        public static int Add(int first, int second)
        {
            return first + second;
        }

        public static int Add(List<int> Numbers)
        {
            int sum = 0;
            foreach (int num in Numbers){
                sum +=num;
            }
            return sum;
        }
    }
}
