using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            AddNumbers(10, 20, 30, 20);
            AddNumbers2(10, 20, new int[]{30, 40});
            AddNumbers3(10, 20, new int[] { 50, 40 });
            AddNumbers4(10, 20, new int[] { 50, 60 });
        }

        // Using the parameter arrays
        public static void AddNumbers(int firstNumber, int secondNumber, params object[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {

                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total : " + result);
        }

        
        // we are using the method overloaded version of the AddNumbers2
        public static void AddNumbers2(int firstNumber, int secondNumber)
        {
            AddNumbers2(firstNumber, secondNumber, null);
        }
        public static void AddNumbers2(int firstNumber, int secondNumber, int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {

                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Sum : " + result);
        }

        //Specifying the parameters defaults
        public static void AddNumbers3(int firstNumber, int secondNumber, int[] restOfTheNumbers = null)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {

                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Grand Sum : " + result);
        }

        // By using the optionalAttribute

        public static void AddNumbers4(int firstNumber, int secondNumber, [Optional] int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {

                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Grand Total : " + result);
        }

    }
}
