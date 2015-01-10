using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3];
            customers[0] = new Customer{
                Name= "Mark",
                Gender = Gender.Male
            };
            customers[1] = new Customer
            {
                Name = "Allen",
                Gender = Gender.Female
            };
            customers[2] = new Customer
            {
                Name = "Barney",
                Gender = Gender.Female
            };
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name = {0} and  Gender: {1} ", customer.Name, GetGender(customer.Gender));
            }
            
        }
 
            public static string GetGender(Gender gender){
                switch (gender){
                    case Gender.Unknown:
                         return "unknown";
                     case Gender.Male:
                         return "male";
                     case Gender.Female:
                         return "female";
                    default:
                        return "Invalid";
                }
            }
  }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        //0= unknown
        //1=  known
        //2= female
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}
