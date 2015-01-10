using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert.ToString__
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer();
            string str = System.Convert.ToString(C1);
            Console.WriteLine(str);
        }
    }
    public class Customer
    {
        public string Name { get; set; }
    }
}
