﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();

            Console.WriteLine("name of Employee with Id = 1 is : " +company[1]);
            Console.WriteLine("name of Employee with Id = 2 is : " + company[2]);
            company[2] = "Zaman";
            Console.WriteLine("name of Employee with Id = 2 is : " + company[2]);
        }

    }
}
