using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class FirstAppClass
    {
        static void Main(string[] args)
        {
            Console.Write("Hello ");
            Afunction();
            Console.WriteLine("Please enter your name: ");
            String userName= Console.ReadLine();
            Console.WriteLine("Hello " + userName);//Concatenating the strings
            Console.WriteLine("Hello {0}. This is using the placeholder method", userName);

            bool b = true;
            int i = 0;
            Console.WriteLine( int.MinValue);
            Console.WriteLine(int.MaxValue);

            string Name = "\"Kushal Pradhan is my name\"";
            Console.WriteLine(Name);
            String link1 = "C:\\Users\\Kushal\\Documents\\Visual Studio 2013\\Projects";
            Console.WriteLine("line1: " + link1);
            String link2 = @"C:\Users\Kushal\Documents\Visual Studio 2013\Projects";
            Console.WriteLine("line2: " + link2);

            int? TicketsOnSale = null;
            int AvailableTickets=TicketsOnSale ?? 0;// this mean if the AvailableTickets is null then use the default value of 0;
        

            Console.WriteLine("Availale tickets: "+AvailableTickets);
            float f= 13.45F;
            int k=(int)f;
            int j= Convert.ToInt32 (f);


            String num = "100";
            int l = int.Parse(num);
            String num1 = "100KP";
                
            int result = 0;
            bool sucess=int.TryParse(num1, out result); // it has boolean conversion data type
            if (sucess)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Please enter a valid number: It was not a valid number");
            }
            Console.ReadLine();
        }
        static void Afunction()
        {
            Console.WriteLine("world");
        }

    }
}
