using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomer
    {
        void Print();
    }
    interface ICusotmerFinal : ICustomer
    {
        void PrintFinal();
    }
    interface ICustomer2
    {
        void PrintAgain();
    }
  public class Customer : ICustomer2,ICusotmerFinal
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
        public void PrintFinal()
        {
            Console.WriteLine("Final Print");
        }
        public void PrintAgain()
        {
            Console.WriteLine("Hello again from the second  print");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.Print();
            C1.PrintAgain();
            C1.PrintFinal();
            Console.ReadLine();
        }
    }
}
