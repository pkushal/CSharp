using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private int _Id;
        private string _name;
        private int _passmark = 35;
        

        public int Id
        { // it will have no parameters but will have set and get accessor
            set{
                if (value <= 0)
                {
                    throw new Exception("Student Id cannot be negative");
                }
                this._Id = value;
            }
            get{
                return this._Id;
            }
            
        }

        public string Name
        { // it will have no parameters but will have set and get accessor
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Student name cannot be negative");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name)?"No Name":this._name;
            }

        }
        public int Passmark
        { // it will have no parameters but will have set and get accessor
           
            get
            {
                return this._passmark;
            }

        }
        public string City
        {
            set;
            get;
        }
        public string Email {set;get;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 101;
            s.Name = "kushal Properties";
            s.Email="kushal.pdn@gmail.com";
            s.City = "Tansen";
            Console.WriteLine(s.Id + "  "+ s.Name+" "+s.Passmark+ " "+s.Email + " " +s.City);
            
            Console.ReadLine();
        }
    }
}
