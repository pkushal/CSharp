using System;

namespace ProblemsWithMultipleClassInheritance
{
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Default implementation A");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Implementation from B");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Implementation from C");
        }
    }

    class D : B, C
    {
      // doesn't allow multiple class inheritance due to diamond problem
    }
    class Program
    {
        static void Main(string[] args)
        {
            //D d = new D();
            //d.Print();
        }
    }
}
