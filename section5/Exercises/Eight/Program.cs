using System;

namespace Eight
{
    class Program
    {
        static void Main(string[] args)
        {
            //random number
            // var count =0;
            int random = new Random();
            Console.WriteLine(Int32.Parse(random.Next(1,10)));

            System.Console.WriteLine("Guess number");
            int guess = Int32.Parse(Console.ReadLine());
            if (guess == random)
            {   
                // count ++;
                System.Console.WriteLine("You Won!");   
            }

            else
            {
                {
                    System.Console.WriteLine("You lost...");
                }
            }
            
        }
    }
}

            // var random = new Random();

            // const int pwLength = 10;
            // var buffer = new char[pwLength];

            // for (var i = 0; i < pwLength; i++)
            
            //     // System.Console.WriteLine(random.Next());    
            //     // System.Console.WriteLine(random.Next(1, 10)); 
            //     // System.Console.Write((char)('a' + random.Next(0, 26)));
            //     buffer[i] = (char)('a' + random.Next(0, 26));
                
            //     var password = new string(buffer);

            //     System.Console.WriteLine(password); 
