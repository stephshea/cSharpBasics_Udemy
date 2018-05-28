using System;
using System.Collections.Generic;
using System.Text;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine(); 

            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];
            var reversed = new string(array);                             
            Console.WriteLine("reversed: " + reversed);
        }
    }
} 

