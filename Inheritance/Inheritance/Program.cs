using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string email;
        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Email: " + email);
        }
    }
    public class FullTimeEmployee : Employee
    {
       public float YearlySalary;
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }


    public class ParentClass
    {
        //this is the default constructor
        public ParentClass()
        {
            Console.WriteLine("Parent constructor called");
        }

        //second constructor
        public ParentClass(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass()
            : base("Message class controlling the Parent class")
        {
            Console.WriteLine("Child class Constructor called");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee();
            fte.FirstName = "Kushal";
            fte.LastName = "Pradhan";
            fte.email = "kushal.pdn@gmail.com";
            fte.YearlySalary=120000;
            fte.PrintFullName();

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Aman";
            pte.LastName = "Khatru";
            pte.email = "amankhatri7@gmail.com";
            pte.HourlyRate = 120000;
            pte.PrintFullName();

            Console.ReadLine();
        }
    }
}
