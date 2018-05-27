using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            // int userInt1;
            // int userInt2;

            Console.WriteLine("Enter a number: ");
            int userInt1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter another number: ");
            int userInt2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(userInt1, userInt2));
        }        
    }
}
