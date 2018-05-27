using System;

namespace section3
{
    class Program
    {
        static void Main(string[] args)
        {  
            try
            {
                var number = "1234";
                byte a = Convert.ToByte(number);
                Console.WriteLine(a);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("can't convert to a byte");
            }

             try
            {
                string str = "true";
                bool c = Convert.ToBoolean(str);
                Console.WriteLine(c);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("can't convert to a boolean");
            }
            
            // byte b = 1;
            // int i = b;
            // Console.WriteLine(i);
            
            int i = 1;
            //typecasting
            byte b = (byte) i;
            Console.WriteLine(b);

            const float Pi = 3.14f;
            
            var two = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "Abby";
            var isWorking = false;

            Console.WriteLine(two);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            var d = 10;
            var e = 3;

            Console.WriteLine((float) d / (float) e);
                                    
        }
    }
}
