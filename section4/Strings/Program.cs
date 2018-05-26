using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Abby";
            var lastName = "Shea";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format("y name is {0} {1}", firstName, lastName);

            var names = new string[3] {"Abby", "Judy", "Reggi"};
            var formattedNames = string.Join(", ", names);
                System.Console.WriteLine(formattedNames);

            var text =@"Hi Abby
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\filder4";
                System.Console.WriteLine(text);

            //both S and s string same thing; need using System for S
            // String lastName = "shea";
            // string lastName2 = "shea";

            //Int32 and int same thing
            Int32 i = 1;
            int j = 33;
            
            System.Console.WriteLine(i+j);
        }
    }
}
