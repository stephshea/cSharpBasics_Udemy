using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    System.Console.WriteLine("we've got promo");
                    break; 

                // case Season.Winter:
                //     System.Console.WriteLine("winter!");
                //     break;

                // case Season.Spring:
                //     System.Console.WriteLine("spring!");
                //     break;
                default:
                    System.Console.WriteLine("don't understand");
                    break;
            }


            int hour = 22;
            if(hour > 0 && hour < 12)
            {
                Console.WriteLine("Morning!");
            }
            
            else if(hour > 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            
            else
            {
                System.Console.WriteLine("Evening!");
            }

            bool isGoldCustomer = true;

            // float price;
            // if (isGoldCustomer)
            // {
            //     price = 19.95f;
            // }
            // else
            // {
            //     price = 29.95f;
            // }

            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(price);

            for (var i = 1; i <= 10;i++)
            {
                if(i%2 == 0 )
                {
                    System.Console.WriteLine(i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            var name = "Abby Shea";
            // for(var i = 0; i < name.Length; i++)
            // {
            //     System.Console.WriteLine(name[i]);
            // }
            
            foreach(var character in name)
            {
                System.Console.WriteLine(character);
            }

            var numbers = new int[] {1, 2, 3, 4};
            
            foreach (var number in numbers)
            {
                System.Console.WriteLine(number);
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i%2 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }

            //Or while but Mosh prefers for loop because cleaner to declare var in loop than outside as in while
            
            var j = 0;
            while  (j <= 10)
            {
                if (j % 2 == 0)
                    System.Console.WriteLine(j);
                
                j++;
            }

            while (true)
            {
                System.Console.Write("Type your name: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {    
                // if (String.IsNullOrWhiteSpace(input))
                //     break;
                    System.Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

            var random = new Random();

            const int pwLength = 10;
            var buffer = new char[pwLength];

            for (var i = 0; i < pwLength; i++)
            
                // System.Console.WriteLine(random.Next());    
                // System.Console.WriteLine(random.Next(1, 10)); 
                // System.Console.Write((char)('a' + random.Next(0, 26)));
                buffer[i] = (char)('a' + random.Next(0, 26));
                
                var password = new string(buffer);

                System.Console.WriteLine(password); 
            
            
            System.Console.WriteLine((int)'a');    

        }
    }
}