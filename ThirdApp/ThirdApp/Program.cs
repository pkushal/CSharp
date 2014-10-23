using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            simpleMethod(ref i);
            Console.WriteLine(i);

            int total=0;
            int product=0;
            Calculate(5, 2, out total, out product);
            Console.WriteLine("Sum: " + total + " product: " + product);

            int[] a = { 1, 2, 3, 4, 5 };
            //paramMethods(6,7,8);
            Console.ReadLine();

        }
        public static void simpleMethod(ref int j)
        {
            j = 101;
        }

        public static void Calculate(int a, int b,out int sum, out int product)
        {
            sum= a + b;
            product = a * b;
        }

        public static void paramMethods(params int[] a){
            Console.WriteLine("Length of the given array is: "+a.Length);
            foreach(int val in a){
                Console.WriteLine(val);
            }
        }
    }
}
