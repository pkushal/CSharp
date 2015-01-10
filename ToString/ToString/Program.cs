using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            C1.FirstName = "Kushal";
            C1.LastName = "Pradhan";
            Console.WriteLine(C1.ToString());
        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return FirstName +" "+ LastName;
        }
    }
}
