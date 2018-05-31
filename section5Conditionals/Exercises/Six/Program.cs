using System;
using System.Collections.Generic;

namespace Six
{
    class Program
    {
        static void Main(string[] args)
        {
        int total = 0;

        while(true)
        {
            Console.WriteLine("enter a number or ok to exit");
            var input = Console.ReadLine();

            if (input.ToLower() == "ok")
            break;
            
            total += Convert.ToInt32(input);
        }
         System.Console.WriteLine(total);
          
        }      
    }
}



            // while (true)
            // {
            //     System.Console.Write("Type your name: ");
            //     var input = Console.ReadLine();
            //     if (!String.IsNullOrWhiteSpace(input))
            //     {    
            //     // if (String.IsNullOrWhiteSpace(input))
            //     //     break;
            //         System.Console.WriteLine("@Echo: " + input);
            //         continue;
            //     }

            //     break;
            // }
