using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Employee{
        public string FirstName="FN";
        public string LastName = "LN";
        public virtual void PrintFullName() // virtual indicates that the derived class can override this method
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName +" Full time");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Part time");
        }
    }
    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + " Temp time");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];
            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee e in employees)
            {
                e.PrintFullName();
            }
            Console.ReadLine();
        }
    }
}
