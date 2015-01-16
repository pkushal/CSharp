using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(){
                Id = 101,
                Name= "Kushal1",
                Salary = 75000
            };

              Customer C2 = new Customer(){
                Id = 102,
                Name= "Kushal2",
                Salary = 85000
            };

              Customer C3 = new Customer(){
                Id = 103,
                Name= "Kushal3",
                Salary = 80000
            };

             Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
             dictionaryCustomers.Add(C1.Id, C1);
             dictionaryCustomers.Add(C2.Id, C2);
             dictionaryCustomers.Add(C3.Id, C3);
             Customer Customer100 = dictionaryCustomers[101];
             Console.WriteLine( " Id: {0}, Name=  {1} and salary = {2} ", Customer100.Id, Customer100.Name, Customer100.Salary);
             Console.WriteLine("-------------------------------------------------");

             foreach (KeyValuePair<int, Customer> customerkeyvaluePair in dictionaryCustomers)
             {
                 Customer cust = customerkeyvaluePair.Value;
                 Console.WriteLine("Id: {0} , Name: {1} and Salary = {2} ", cust.Id, cust.Name,cust.Salary);
             }

             Console.WriteLine("-------------------------------------------------");
            //var also works the same as the KeyValuePair<>
             foreach (var customerkeyvaluePair in dictionaryCustomers)
             {
                 Customer cust = customerkeyvaluePair.Value;
                 Console.WriteLine("Id: {0} , Name: {1} and Salary = {2} ", cust.Id, cust.Name, cust.Salary);
             }
             Console.WriteLine("-------------------------------------------------");

            //Looping in the keys
             foreach (int key in dictionaryCustomers.Keys)
             {
                 Console.WriteLine(key);
             }
             Console.WriteLine("-------------------------------------------------");
            // Looping in the values
             foreach (Customer cust in dictionaryCustomers.Values)
             {
                 Console.WriteLine("Id: {0} , Name: {1} and Salary = {2} ", cust.Id, cust.Name, cust.Salary);
             }
             Console.WriteLine("-------------------------------------------------");
            // you can also use the following methods
             if (!dictionaryCustomers.ContainsKey(1005))
             {
                 Console.WriteLine("DO some thing Kushal....you can also check the containsValue as well");
             }

             Console.WriteLine("-------------------------------------------------");
            //TryGetValue()
            Customer output;
            if (dictionaryCustomers.TryGetValue(101, out output))
            {
                Console.WriteLine("Id: {0} , Name: {1} and Salary = {2} ", output.Id, output.Name, output.Salary);
            }
            else
            {
                Console.WriteLine( "Key not found");
            }
            Console.WriteLine("-------------------------------------------------");


            // using the count function..to count the total number of elements in the dictionary
            Console.WriteLine("Total number of items is : " + dictionaryCustomers.Count);
            Console.WriteLine("-------------------------------------------------");
                //overloaded version of the count function.. here we are counting the customers with salary greater than 76K
            Console.WriteLine("Total number of Customers having salary greater than 76K is : " + dictionaryCustomers.Count(kvp => kvp.Value.Salary > 76000));

            // Remove()
            dictionaryCustomers.Remove(101); // will remove the item with key 101 
            // if the key is not present then nothing will happen and no error as well

            //Clear ()
          //  dictionaryCustomers.Clear(); // This will clear all the items in the dictionary


            Console.WriteLine("-------------------------------------------------");
            //converting the array into dictionary
            Customer[] customers = new Customer[3];
            customers[0] = C1;
            customers[1] = C2;
            customers[2] = C3;

            Dictionary<int, Customer> dictonary = customers.ToDictionary(cust => cust.Id, cust => cust);// key is id and value is Customer

            foreach (var item in dictonary)
            {
                 Customer cust = item.Value;
                 Console.WriteLine("Id: {0} , Name: {1} and Salary = {2} ", cust.Id, cust.Name, cust.Salary);
            }

            Console.WriteLine("---------------------------------------------");
            //Converting the list to dictionary and then looping in that dictionary
            
            List<Customer> custom = new List<Customer>();
            custom.Add(C1);
            custom.Add(C2);
            custom.Add(C3);
            Dictionary<int, Customer> dicto = customers.ToDictionary(cust => cust.Id, cust => cust);
            foreach (var item in dicto)
            {
                Customer cust = item.Value;
                Console.WriteLine("Id..: {0} , Name: {1} and Salary = {2} ", cust.Id, cust.Name, cust.Salary);
            }
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
