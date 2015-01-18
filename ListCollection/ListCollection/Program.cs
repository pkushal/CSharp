using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer()
            {
                Id = 101,
                Name = "Kushal1",
                Salary = 75000
            };

            Customer C2 = new Customer()
            {
                Id = 102,
                Name = "Kushal2",
                Salary = 85000
            };

            Customer C3 = new Customer()
            {
                Id = 103,
                Name = "Kushal3",
                Salary = 80000
            };

            //array of Customer object; we have to predefine the size the array unlike in the List
            Customer[] customer = new Customer[2];
            customer[0] = C1;
            customer[1] = C2;

            //List can grow in size automatically
            List<Customer> customerList = new List<Customer>(2); // 2 is the initial size of the list
            customerList.Add(C1);
            customerList.Add(C2);
            customerList.Add(C3);// even though the initial size is 2, it can grow Automatically
            // we can access the List using the index numbers
            Console.WriteLine("Customer Name: {0}, ID: {1}, Salary: {2}",customerList[0].Name, customerList[0].Id, customerList[0].Salary);
            //Counting the number of objects in the List
            Console.WriteLine("To find the numbers of object in the list we can use CustomerList.count : " +customerList.Count);
            // List is strongly typed and we cannot add the object of different type in this type of List collection.

            customerList.Insert(1, C2);// This will insert the C2 Customer in the index 1 and the rest of the objects will be pushed back.
            //Add will only add the new customers at the last index.
            
            customerList.IndexOf(C2);// This will give the index of the Customer C2, if more than one C2 are present, it will give the first object
            Console.WriteLine(customerList.IndexOf(C2));
            customerList.IndexOf(C2, 1);// This will look for C2 from index 1, 1 is inclusive
            customerList.IndexOf(C2, 1, 2); // It will look for 2 C2 objects starting from index 1
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
