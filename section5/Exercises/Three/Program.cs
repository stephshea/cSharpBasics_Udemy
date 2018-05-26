using System;

namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter height: ");
            int userHeight = Int32.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Enter width: ");
            int userWidth = Int32.Parse(Console.ReadLine());

            if(userHeight > userWidth)
            {
            System.Console.WriteLine("Portrait");
            }
            else if(userHeight < userWidth)
            {
                System.Console.WriteLine("Landscape");   
            }

            else
            {
                System.Console.WriteLine("Square");       
            }
        }
    }
}
