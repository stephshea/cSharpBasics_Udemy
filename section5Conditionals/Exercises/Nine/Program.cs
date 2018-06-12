using System;
using System.Collections.Generic;

namespace Nine
{
    class Program
    {
        public static void Main()
        {
            //maximum of the numbers 
            Console.WriteLine("Enter 5 comma seperated ints");
            var series = Console.ReadLine();
            var numbers = series.Split(',');
            var max = Convert.ToInt32(numbers[0]);           

            foreach(var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                {
                    max = number;
                }
            }             
                Console.WriteLine("Max: " + max);
        }
    }
}