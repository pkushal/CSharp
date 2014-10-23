using System;

using PATA=ProjectA.TeamA;
using PATB=ProjectA.TeamB;


namespace NameSpaceDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            PATA.ClassA.print();
            PATB.ClassA.print();
            Console.ReadLine();
        }
    }
}
