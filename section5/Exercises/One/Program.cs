using System;

namespace One
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInt;
            Console.WriteLine("Enter a number 1-10: ");
            userInt= Int32.Parse(Console.ReadLine());

            if (userInt > 0 && userInt < 11)
            System.Console.WriteLine("Valid");
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }
    }
}
