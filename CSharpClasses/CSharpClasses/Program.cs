using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClasses
{
    class Customer
    {
        string _firstName;
        string _lastName;
        
        // Constructor
        public Customer(string FirstName, string LastName)
        {
            this._firstName = FirstName; // this keyword is for better readability
            _lastName = LastName;
        }

        //this is for when we don't have the name is provided like a default consctructor
        public Customer()
            : this("NO first name entered ", "NO last name provided ")
        {
        }

        public void PrintFullName()
        {
            Console.WriteLine("Full Name = {0}", _firstName + " " + _lastName);
            Console.ReadLine();

        }
        //destructors: don't take parameters...don't need destructors..we don't have to call them..works automatically
        ~Customer()
        {
            //Clean up code here
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Kushal", "Pradhan");
            c1.PrintFullName();
            Customer c2 = new Customer();
            c2.PrintFullName();
        }
    }
}
