﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                    break;

                numbers.Add(Convert.ToInt32(input));
            }

            // var uniques = new List<int>();
            // foreach (var number in numbers)
            // {
            //     if (!uniques.Contains(number))
            //         uniques.Add(number);
            // }
            // var uniques = GetUniqueNumbers(numbers);

            System.Console.WriteLine("Unique numbers: ");
            foreach (var number in GetUniqueNumbers(numbers))
                System.Console.WriteLine(number);
            
        }

        public static List<int> GetUniqueNumbers(List<int> numbers)
        {
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            return uniques;
        }
    }
}
