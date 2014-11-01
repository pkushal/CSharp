using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClassInheritanceUsingInterface
{
    interface IA
    {
        void MethodA();
    }
    class A : IA
    {

        public void MethodA()
        {
            Console.WriteLine("Print from the Method A in Class A");
        }
    }
    interface IB
    {
        void MethodB();
    }
    class B : IB
    {

        public void MethodB()
        {
            Console.WriteLine("Print from the Method B in Class B");
        }
    }
    class AB : IA, IB
    {
        A a = new A();
        B b = new B();
        public void MethodA()
        {
            a.MethodA();
                    }
        public void MethodB()
        {
            b.MethodB();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AB ab = new AB();
            ab.MethodA();
            ab.MethodB();
            Console.ReadLine();
        }
    }
}
