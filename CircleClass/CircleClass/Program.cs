using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleClass
{
    class Circle
    {   
        //these are states
        static float _PI; //this is static field, we make this static because it doesn't change
        int _Radius; // this is an instance field, since there is no static field infront of it.

        //Constructor
        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        static Circle(){
            Circle._PI =3.141F;
        }
        
        static void Print()
        {
            //some codes
        }
        public float CalculateArea()
        {
            return Circle._PI * this._Radius * this._Radius;// NO this for static members, it doesn't belong to any object; it is common
                                                            //But we can do like Circle._PI
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(2);
            Console.WriteLine("The area is {0}",c.CalculateArea());
            Circle c2 = new Circle(6);
            Console.WriteLine("The area is {0}", c2.CalculateArea());
            //we cannot do c.Print(); 
            //Just do like Print();
            Console.ReadLine();
        }
    }
}
