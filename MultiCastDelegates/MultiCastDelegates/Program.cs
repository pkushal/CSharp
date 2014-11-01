using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegates
{
    public delegate void SampleDelegate(out int Integer);
    class Program
    {
        public static void SampleMethod1(out int num)
        {
            num = 1;
            Console.WriteLine("Sample method 1 Invoked");
            
        }
        public static void SampleMethod2(out int num)
        {
            num = 2;
            Console.WriteLine("Sample method 2 Invoked");
            
        }
      
        static void Main(string[] args)
        {

            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;
            int  DelegateOutparameterValue = -1;
            del(out DelegateOutparameterValue);
            Console.WriteLine(DelegateOutparameterValue);
            Console.ReadLine();
        }
    }
}
