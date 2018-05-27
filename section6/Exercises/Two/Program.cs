using System;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine(); 
            System.Console.WriteLine(name + name.Length);

            string[] reverse = new string[]{ name };

             foreach (var n in reverse)
            {
                Console.WriteLine("name" + n);
            }
              
Console.WriteLine("reverse: " + reverse);
//             name = new [] {name.Length};
// System.Console.WriteLine(name + name.Length);
            
            Array.Reverse(reverse);
            foreach (var n in reverse)
            {
                Console.WriteLine("name" + n);
            }
        }
    }
} 

