using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
  public  abstract class Customer
    {
        public abstract void Print();
       public void NormalMethod()
        {
            Console.WriteLine("Normal method");
        }
    }
   public class  Program : Customer
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.NormalMethod();
            P.Print();
            Console.ReadLine();
        }
       
        public override void Print()
        {
            Console.WriteLine("the method from the abstract class");
        }
    }
}
