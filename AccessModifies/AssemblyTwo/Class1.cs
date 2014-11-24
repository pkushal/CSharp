using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {
        public void Print()
        {
            // AssemblyOneClass1 A1 = new AssemblyOneClass1(); cannot be done without adding it in the referernce
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            //A1.ID = 101;  cannot be done because ID is internal...protected internal can address this problem
            base.IDPro = 202; // this assembly has to inherit from the assembly one and it can access the protected internal members

            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.IDPro = 205;
        }
    }
}
