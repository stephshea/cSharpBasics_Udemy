using System;
using System.Collections.Generic;

namespace Seven
{
    class Program
    {
        static void Main(string[] args)
        {
            //factorial
            int num = 0;
            int factorial = 1;

            Console.WriteLine("Enter a number: ");
            num = Int32.Parse(Console.ReadLine());
            while (num > 0)
            {
                factorial *= num;
                --num; 
            }
            Console.WriteLine(factorial);  
        }
    }
}
