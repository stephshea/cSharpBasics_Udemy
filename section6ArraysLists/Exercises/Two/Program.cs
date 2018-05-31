using System;
using System.Collections.Generic;
using System.Text;

namespace Two
{
   internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            var name = Console.ReadLine(); 

            var array = new char[name.Length];

            for (var i = name.Length; i > 0; i--)
            array[name.Length - i] = name[i -1];

            var reversed = new string(array);
            Console.WriteLine("reversed: " + reversed);

            // var array = new char[name.Length];
            // for (var i = name.Length; i > 0; i--)
            //     array[name.Length - i] = name[i - 1];
            // var reversed = new string(array);                             
            
        }

        // public static string ReverseName(string name)
        // {
        //     var array = new char[name.Length];
        //     for (var i = name.Length; i > 0; i--)
        //         array[name.Length - i] = name[i - 1];
        //     // var reversed = new string(array);

        //     // return reversed;  
        //     return new string(array);              
    
    }
} 

