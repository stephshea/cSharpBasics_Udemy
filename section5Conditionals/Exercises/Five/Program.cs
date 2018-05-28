using System;

namespace Five
{
    class Program
    {
        static void Main(string[] args)
        { 
            int count = 0;

            for (var i = 1; i < 100; i++)
            {
                if (i%3 == 0)
                count++;
            }
            System.Console.WriteLine("Numbers divisible by 3 between 1 and 100: {0} ", count);
        }
    }
}
