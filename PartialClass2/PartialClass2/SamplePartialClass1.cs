using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass2
{
    public partial class SamplePartialClass
    {
        partial void SamplePartialMethod(); // no implementation here, so the compiler will ignore this; its implementation is in 
                                            // other part of the partial class
        public void PublicMethod()
        {
            Console.WriteLine("Public method Invoked");
            SamplePartialMethod();
        }
    }
   
}
