using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    //here everything is same as in the class..only difference is we have used struct instead of class.
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int ID
        {
            get { return this._id; }
            set { this._id = value; }
        }
        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Id: {0} and Name: {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101,"Mark");
            c1.PrintDetails();

            Customer c2 = new Customer();
            c2.ID = 102;
            c2.Name = "Jake";
            c2.PrintDetails();
            Console.ReadLine();

            //this is object initializer syntax (introduced in C# 3.0)...we can use this to intitialize classes as well
            Customer c3 = new Customer
            {
                ID=103,
                Name="Aman"
            };
            c3.PrintDetails();

        }
    }
}
