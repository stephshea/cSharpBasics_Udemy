using System;

namespace section8
{
    class Strings
    {
        static void Main(string[] args)
        {
            var fullName = "Abby Shea ";
            Console.WriteLine("Trim:  '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper:  '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            System.Console.WriteLine("FirstName: " + firstName);
            System.Console.WriteLine("LastName: " + lastName);

            var names = fullName.Split(' ');
            System.Console.WriteLine("FirstName: " + names[0]);
            System.Console.WriteLine("LastName: " + names[1]);

            System.Console.WriteLine(fullName.Replace("Abby", "AbbyDog"));

            if (String.IsNullOrWhiteSpace(" "))
                System.Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            System.Console.WriteLine(age);     

            float price = 29.95f; 
            
            System.Console.WriteLine(price.ToString("C0"));
        }
    }
}
