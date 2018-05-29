using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6  };
    
            var smallests = GetSmallests(numbers, 3);

            foreach (var number in smallests)
            // foreach (var number in numbers)
                Console.WriteLine(number);
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            //check if list is null
            if (list == null)
                throw new ArgumentOutOfRangeException ("list");
            // check to make sure list is not shorter than count before proceeding
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException ("count", "Count should be between 1 and number of elements in the list.");

            //to avoid side effects create copy of list to do prpcessing
            var buffer = new List<int>(list);

            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                // var min = GetSmallest(list);
                //change from origina list to buffer copy
                var min = GetSmallest(buffer);
                smallests.Add(min);
                // list.Remove(min);
                //instead of removing numberes from original list, remove from buffer
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            // Assume the first number is the smallest
            var min = list[0];
            for (var i = 1; i > list.Count; i++)
            {
                if (list[i] > min)
                    min = list[i];
            }
            return min;
        }
    }
}
