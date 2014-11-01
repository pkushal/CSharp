using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void Method1();
     }
    interface I2
    {
        void Method1();
    }

    interface Inter
    {
        void Method2();
    }
    interface face
    {
        void Method2();
    }
    class Program :I1,I2,Inter,face
    {
        public void Method2()
        {
            Console.WriteLine("Default inteface method 2");
        }
        void face.Method2()
        {
            Console.WriteLine("Not so Default inteface method 2");
        }
        void I1.Method1() // no access modifier
        {
            Console.WriteLine("I1 interface method");
        }

        void I2.Method1() // no access modifier
        {
            Console.WriteLine("I2 interface method");
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            //P.Method1(); There is an ambuiguity it is invoking the I1 or I2's method
            ((I1)P).Method1();
            ((I2)P).Method1();
            // we can do like
            I1 Pro = new Program();
            Pro.Method1();
            P.Method2();
            ((face)P).Method2();

            Console.ReadLine();
        }
    }
}
