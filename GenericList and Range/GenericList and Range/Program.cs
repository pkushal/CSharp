using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList_and_Range
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

            //List can grow in size automatically
            List<Customer> customerList = new List<Customer>(2); 
            customerList.Add(C1);
            customerList.Add(C2);
            customerList.Add(C3);

            if (customerList.Contains(C3))
            {
                Console.WriteLine("Customer 3 is present in the list");
            }else{
                Console.WriteLine("Customer 3 is not present in the list");
            }

            //using the lambda expression in the exist method
            if (customerList.Exists(cust => cust.Name.StartsWith("K")))
            {
                Console.WriteLine("Wala this is a use of lambda expression");
            }
            else
            {
                Console.WriteLine("Waalla");
            }

            // Using the find method; it just returns one object
            Customer C = customerList.Find(cust => cust.Salary > 76000);
            Console.WriteLine("Customer Name: {0}, ID: {1}, Salary: {2}", C.Name, C.Id, C.Salary);//gives the first matching item
            

            //Using the findLast() method
            Customer Clast = customerList.Find(cust => cust.Salary > 1000);
            Console.WriteLine("Customer Name: {0}, ID: {1}, Salary: {2}", Clast.Name, Clast.Id, Clast.Salary); //gives the last matching item


            //Using the findAll() method
            Console.WriteLine("----------------------------------------------------");
            List<Customer> CAll = customerList.FindAll(cust => cust.Salary > 1000);
            foreach (var item in CAll)
            {
                Console.WriteLine("Customer Name: {0}, ID: {1}, Salary: {2}", item.Name, item.Id, item.Salary);
            }

            //Using FindIndex() method
            Console.WriteLine("----------------------------------------------------");
            int index = customerList.FindIndex(cust => cust.Salary > 75000);
            Console.WriteLine("Index of the customer who earns more than 75000: " + index);

            int indexoverloaded = customerList.FindIndex(2, cust => cust.Salary > 4000);
            Console.WriteLine("Index of the customer who earns more than 75000: " + indexoverloaded);

            //Using the FindLastIndex() method
            Console.WriteLine("----------------------------------------------------");
            int lastIndex = customerList.FindLastIndex(cust => cust.Salary > 4000);
            Console.WriteLine("Last index : "+ lastIndex);


            // Array to List:
            Customer[] customer = new Customer[2];
            customer[0] = C1;
            customer[1] = C2;
            List<Customer> listCustomer = customer.ToList(); // we have converted array to list

            //List to an array:

            Customer[] array = customerList.ToArray();

            //ToDictionary() method
            Console.WriteLine("-----------Dictionary----------------");
            Dictionary<int, Customer> dictionary = customerList.ToDictionary(x => x.Id);
            foreach (var Cus in dictionary)
            {
                Customer item = Cus.Value;
                 Console.WriteLine("Customer Name: {0}, ID: {1}, Salary: {2}", item.Name, item.Id, item.Salary);
            }

        }
        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}
