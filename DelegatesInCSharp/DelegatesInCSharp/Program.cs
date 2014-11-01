using System;
using System.Collections.Generic;

namespace DelegatesInCSharp
{

    public delegate void HelloFunctionDelegate(string str);
    //this points to any method which has a void return type and take a string input
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello); // we are passing in the name of the function pointer
            del("hello from delegate");
            Console.ReadLine();
        }

        public static void Hello(string str)
        {
            Console.WriteLine(str);
        }

     }
}
