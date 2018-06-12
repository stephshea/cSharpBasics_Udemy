using System;
using System.Collections.Generic;

namespace Eight
{
    class Program
    {
        public static void Main(string[] args)
        {
            //random number
            // var count =0;

            var rand = new Random().Next(1,10);

            for (int i = 0; i < 4; i++)
            {
                System.Console.WriteLine("Guess number");
                int guess = Int32.Parse(Console.ReadLine());

                if (guess == rand)
                {
                    System.Console.WriteLine("You Won!");
                }

            }
                 System.Console.WriteLine("You lost...");

        }
    }
}