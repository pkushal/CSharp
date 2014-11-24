using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"C:\Users\Kushal\Documents\Visual Studio 2013\Projects\README1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
              }
            catch(Exception e)
            {
                Console.WriteLine("Please check if the file exists");
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
              
            }
            finally
            {
                if (streamReader != null)
                {
                    Console.WriteLine("Finally Block....streamReader was NOT null");
                    streamReader.Close();
                }
             }

            Console.WriteLine("Out of exception handling");
            Console.ReadLine();
        }
    }
}
