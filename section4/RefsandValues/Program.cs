using System;

namespace RefsandValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //value types a is 10 on stack; then b = value in a -- completely independent
            var a  = 10;
            var b = a;
            b++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            //ref type arr1 created on heap in mem location and arr address created on stack; copy of arr2 -- points to heap and creates mem address on stack
            var array1 = new int[3]{1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            System.Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));
        }
    }
}
