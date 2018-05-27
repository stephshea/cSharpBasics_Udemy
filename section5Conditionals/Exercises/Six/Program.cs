using System;

namespace Six
{
    class Program
    {
        static void Main(string[] args)
        {
        int total = 0;
        var num;
        
        Console.WriteLine("enter a number or ok");
        num = Int32.Parse(Console.ReadLine());
        while(typeof(num) == "number")
        {
        total += num;
        System.Console.WriteLine(total);
        }
        
        break;   
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
