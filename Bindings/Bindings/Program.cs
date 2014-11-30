using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Bindings
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer C1 = new Customer(); // this is early binding
            string fullname = C1.GetFullName("Kushal", "Pradhan");
            Console.WriteLine("Full name is {0}", fullname);



            Assembly executingAssembly = Assembly.GetExecutingAssembly(); // getting the current executing assembly
            Type customerType = executingAssembly.GetType("Bindings.Customer"); // getting the type of the Customer class
            object customerInstance = Activator.CreateInstance(customerType); // here we are instantiating the Customer type
            MethodInfo GetFullNameMethod = customerType.GetMethod("GetFullName"); // getting the methods the Customer Class

            //parameter for the method
            string[] parameters = new string[2];
            parameters[0] = "Walla";
            parameters[1] = "Khara";

            string fullNamelateBinding = (string) GetFullNameMethod.Invoke(customerInstance,parameters); // instance and the parameters of the method
            Console.WriteLine("Late Binding Full name : {0}", fullNamelateBinding);
            // the thing is here we have not done any new and it will not show any error at compile time, if there is any
            Console.ReadLine();
        }
    }
    public class Customer
    {
        public string GetFullName(string first, string second)
        {
            return first + "  " + second;
        }
    }
}
