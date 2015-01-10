using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_Class
{
    public class Customer
    {
   
        public string LastName {set;get;}
        public string FirstName { set; get; }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
        
    }
}
