using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // This is added for the reflection 


namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(); // this is early binding, we are creating instance at compile time.. other is late binding.
            // late binding is done by reflection
            Type T = Type.GetType("Reflection.Customer"); // we are trying to get all the properties of the Customer class using Reflection
            //Type T = typeof(Customer); we can also do like this
            //Type T = C1.GetType() we can do this
            Console.WriteLine("Full Name :  {0}", T.FullName);
            Console.WriteLine("Just  Name :  {0}", T.Name);
            Console.WriteLine("Just the  Namespace :  {0}", T.Namespace);
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine("\nProperties in the customer class");
            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine(prop.PropertyType.Name + "  "+ prop.Name);
            }

            Console.WriteLine("\nMethods in the customer class");
            MemberInfo[] methods = T.GetMethods();
            foreach (MethodInfo meth in methods)
            {
                Console.WriteLine(meth.ReturnType.Name + "  " + meth.Name);
            }


            Console.WriteLine("\nConstructors in the customer class");
            ConstructorInfo[] cons = T.GetConstructors();
            foreach (ConstructorInfo con in cons)
            {
                Console.WriteLine(con.ToString());
            }

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer(int ID, string Name)
        {
            this.Id = ID;
            this.Name = Name;
        }
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }
        public void PrintID()
        {
            Console.WriteLine("ID = {0}", this.Id);
        }
        public void PrintName()
        {
            Console.WriteLine("Name = {0}", this.Name);
        }
    }
}
