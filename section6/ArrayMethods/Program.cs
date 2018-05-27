using System;

namespace ArrrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };
            
            //Length size of array -- method accessible on object -- not static
            Console.WriteLine("Length: " + numbers.Length);

            //static methods -- accessible from class itself in this case Array class
            //IndexOf()
            var index = Array.IndexOf(numbers, 9);
            System.Console.WriteLine("Index of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);
            foreach (var n in numbers)
                System.Console.WriteLine(n);

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);    
            foreach (var n in another)
            {
                System.Console.WriteLine(n);
            }

            //Sort()
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

            //Reverse()
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }

        }
    }
}
