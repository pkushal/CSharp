using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KushalPackage
{
    class SecondApp
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Please guess a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("did mean :" + num + "  lol.....haha aman");

            switch (num)
            {
                case 10:
                    Console.WriteLine("Wow you got it 10");
                    break;

                default:
                    Console.WriteLine("LOL bad guess");
                    break;
             }
            Console.WriteLine("Do you want to continue: Y or N");
            String decision= Console.ReadLine();
            switch(decision.ToUpper())
            {
                case "Y":
                    goto start;
    
                default:
                    Console.WriteLine("Bye");
                    break;

               }

            int start = 0;
            while (start <= 10)
            {
                Console.WriteLine(start);
                start++;
            }

            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j*2);
            }

            int[] numbers={1,2,3};

           
            foreach(int k in numbers){
                Console.WriteLine(k);
            }

            SecondApp s= new SecondApp();
            s.EvenNumbers();
            EvenNumber2();
                Console.ReadLine();
        }
            public void EvenNumbers(){
                Console.WriteLine("this is from the method");
                int start=0;
                while(start<=20){
                    Console.WriteLine(start);
                    start += 2;
                }
           }

            public static void EvenNumber2()
            {
                Console.WriteLine("this is from the STATIC method");
                int start = 0;
                while (start <= 20)
                {
                    Console.WriteLine(start);
                    start += 2;
                }
            }
    }
}