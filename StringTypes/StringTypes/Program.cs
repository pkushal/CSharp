using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace StringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // it is wise to use the stringBuilder when there is a heavy string manipulation
            StringBuilder userString = new StringBuilder("C#");
            userString.Append(" is good");
            userString.Append("with stringBuilder");
            Console.WriteLine(userString.ToString());

        }
    }
}
