using System;

namespace Four
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter speed limit: ");
            int speedLimit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter speed of car: ");
            int speed = Int32.Parse(Console.ReadLine());

            int demerits;
         
            if (speed < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                demerits = (speed - speedLimit)/5;
                
                if (demerits > 12)
                    System.Console.WriteLine("License suspended.");
                else
                    System.Console.WriteLine("Demerits: " + demerits);
            }

        
            
        }
    }
}
