using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        public static void Add(int FN, int SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(float FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, float SN)
        {
            Console.WriteLine("Sum = {0}", FN + SN);
        }
        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("Sum ={0}", FN + SN);
        }
        public static void Add(int FN, int SN, out int Sum)
        {
            Console.WriteLine("Sum ={0}", FN + SN);
            Sum = FN + SN;
        }
        static void Main(string[] args)
        {
            Add(1, 2);
            Console.ReadLine();
        }
    }
}
