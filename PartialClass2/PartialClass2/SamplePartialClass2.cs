using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass2
{
    public partial class SamplePartialClass
    {

        // we can also have the implementation and declaration in the same file as
        //  partial void SamplePartialMethod();
        //  partial void SamplePartialMethod()
        //  {
        //    Console.WriteLine("Sample partial method invoked");
        //  }

        partial void SamplePartialMethod()//definition is in other file and the implementation is here
        {
            Console.WriteLine("Sample partial method invoked");
        }
    }
}
