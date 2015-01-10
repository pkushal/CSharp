using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Kushal";
            C1.LastName = "Pradhan";
            Console.WriteLine(C1.GetFullName());

            PartialCustomer C2 = new PartialCustomer();
            C2.FirstName = "Wala";
            C2.LastName = "ooo ";
            Console.WriteLine(C2.GetFullName());
        }
    }
}
