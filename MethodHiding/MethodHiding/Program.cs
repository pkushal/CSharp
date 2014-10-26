using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{

    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string email;
        public void PrintFullName()
        {
            Console.WriteLine("This is from base class "+FirstName + " " + LastName + " Email: " + email);
        }
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
        public new void PrintFullName() // we put a new  in the method to tell that we want to hide this method in parent class
        {
            Console.WriteLine("This is from the derived class: " + FirstName + " " + LastName + " Email: " + email);
        }
    }
    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
        public new void PrintFullName()
        {
            base.PrintFullName();
            //Console.WriteLine("This is from the derived class: "+FirstName + " " + LastName + " Email: " + email);
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
            fte.YearlySalary = 120000;
            fte.PrintFullName();
            ((Employee)fte).PrintFullName(); // fte is casted into employee and then printFullName is invoked in employee type

            PartTimeEmployee pte = new PartTimeEmployee();
            pte.FirstName = "Aman";
            pte.LastName = "Khatru";
            pte.email = "amankhatri7@gmail.com";
            pte.HourlyRate = 120000;
            pte.PrintFullName();


            Employee kpp = new FullTimeEmployee();
            kpp.FirstName = "KPP";
            kpp.LastName = "Pdn";
            kpp.email = "kushal@gmail.com";
            kpp.PrintFullName();

            Console.ReadLine();
        }
    }
}
