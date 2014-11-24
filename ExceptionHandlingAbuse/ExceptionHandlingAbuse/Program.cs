using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Please enter the numerator: ");
            int Numerator;
            bool IsNumeratorConversionSuccessful =  Int32.TryParse(Console.ReadLine(), out Numerator);

             if (IsNumeratorConversionSuccessful)
             {
                Console.WriteLine("Please enter the denominator: ");
                int Denominator;
                bool IsDenominatorConversionSuccessful =  Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    int Result = Numerator / Denominator;
                    Console.WriteLine("Result is {0}", Result);
                }
                else
                 {
                 if(Denominator ==0){
                     Console.WriteLine("Denominator cannot be zero");
                 }else{
                     Console.WriteLine("Denominator should be between {0} and {1} ", Int32.MinValue, Int32.MaxValue);
                 }
             }
             } else{
                 Console.WriteLine("Numerator should be between {0} and {1} ", Int32.MinValue, Int32.MaxValue);
             }}
                 catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
