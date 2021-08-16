using System;

namespace EX08BooleanAlgebra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 50;
            Console.WindowWidth = 200;

            int a = 2;
            int b = 4;

            Console.WriteLine(a == b || a > 0);                     //True
            Console.WriteLine(a + b > 0 && a > 0);                  //True
            Console.WriteLine(a != 5 && a + b > 0);                 //True
            Console.WriteLine((true || false) && a > b);            //False
            Console.WriteLine(3 > 5 && true || a == b);             //False
            Console.WriteLine(b > a && true || false || b > 4);     //True
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true); //True
            Console.WriteLine(true && true || false);               //True
            Console.WriteLine(true && false && true);               //False
            Console.WriteLine(true || false || false);              //True
            Console.WriteLine(false && false);                      //False
            Console.WriteLine(a == 3 && b > 4 || a + 3 > b);        //True
            Console.WriteLine(a > b && b > a && a + a == b);        //False
        }
    }
}
