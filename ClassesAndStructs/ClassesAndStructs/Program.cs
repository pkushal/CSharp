using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndStructs
{
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
       // public Customer(int id, string name)
        //{
          //  this._id = id;
           // this._name = name;
       // }
        public void PrintDetails()
        {
            Console.WriteLine("Id: {0} and Name: {1}", this._id, this._name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            int i = 10;
            if (i == 10)
            {
                int j = 20; //scope of j is only in this if block
                Customer c1 = new Customer(); 
                //object will be stored in heap while the object reference c1 is stored in stack.
                //the scope of c1 reference variable is only in the if block, and the object from the heap will be later destroyed by the
                // garbage collector if the object has no reference.
                c1.ID = 898;
                c1.Name = "Mark";
                c1.PrintDetails();

                Customer c2 = c1;
                c2.Name = "wala";
                Console.WriteLine("C1.Name: {0} and C2.Name: {1}", c1.Name, c2.Name);
                c2.ID = 728908;
                c2.PrintDetails();
                c1.PrintDetails();
            }
            int k = i;
            k++;
            Console.WriteLine("k: "+ k);
            //the change in k will not affect the value in i, since this a value type structure
            Console.WriteLine("I: " + i);

            Console.ReadLine();

        }
    }
}

