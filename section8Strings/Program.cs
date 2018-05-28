using System;
using System.Collections.Generic;
using System.Text;

namespace section8
{
    class Program
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

            var sentence = "This is a really really really really really realy long bit of text";
            var summary = StringUtility.SummarizeText(sentence, 25);
            System.Console.WriteLine(summary);

            var builder = new StringBuilder("Hello Abby");
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            System.Console.WriteLine(builder);

            System.Console.WriteLine("index0: " + builder[0]);

            // const int maxLength = 20;
            // if (text.Length < maxLength)
            //     System.Console.WriteLine(text);
            // else
            // {
            //     var words = text.Split(' ');
            //     var totalCharacters = 0;
            //     var summaryWords = new List<string>();

            //     foreach (var word in words)
            //     {   
            //         summaryWords.Add(word);
            //         totalCharacters += word.Length + 1;
            //         if (totalCharacters > maxLength)
            //             break;
            //     }
            //     var summary = String.Join(" ", summaryWords) + "...";
            //     System.Console.WriteLine(summary);
            // }    
        }    
    }
}
