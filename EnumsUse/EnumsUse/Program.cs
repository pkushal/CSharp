using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Gender gender = (Gender)3;
            int Num = (int)Gender.Unknown;

            Gender gender1 = (Gender)Season.Winter;
            Console.ReadLine();
        }
    }
}

public enum Gender
{
    Unknown =1, Male=2, Female=3
}

public enum Season
{
    Winter =1, Spring=2, Summer=3
}