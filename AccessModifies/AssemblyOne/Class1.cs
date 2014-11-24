using System;

namespace AssemblyOne
{
    public class AssemblyOneClass1
    {
        internal int ID = 101;
        protected internal int IDPro = 201;
    }
    public class AssemblyOneClass2
    {
        public void SampleMethod()
        {
            //this A1 can be accessed anywhere inside the same namespace
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.WriteLine(A1.ID);
        }
    }
}
