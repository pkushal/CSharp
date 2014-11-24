using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndTypeMembers
{
    class Program
    {
        #region kushal
        private int _id { get; set; }
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        #endregion
        public string GetFullName()
        {
            return this._firstName + " " + _lastName;
        }
        static void Main(string[] args)
        {


        }
    }
}
