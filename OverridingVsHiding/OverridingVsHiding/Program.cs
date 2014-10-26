using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingVsHiding
{
    public class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("I am a base Class Print Method");
        }
    }
    public class DerivedClass : BaseClass
    {
//        public new Print(){
                //this is for MethodAccessException hiding, new operator
  //      }
        public override void Print()
        {
            Console.WriteLine("I am a Derived Class Print Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass b = new DerivedClass();
            b.Print();
            DerivedClass d = new DerivedClass();
            d.Print();
            Console.ReadLine();
        }
    }
}
