using System;

namespace section7
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2018, 1, 1 );
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour + ":" + now.Minute);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            System.Console.WriteLine(now.ToLongDateString());
            System.Console.WriteLine(now.ToShortDateString());
            System.Console.WriteLine(now.ToLongTimeString());
            System.Console.WriteLine(now.ToShortTimeString());
            System.Console.WriteLine(now.ToString());
            System.Console.WriteLine(now.ToString("yy-MMMM-dd ddd HH:mm"));

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            System.Console.WriteLine("Duration: " + duration);

            // Properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);

            // Add
            System.Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            System.Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            System.Console.WriteLine("ToString: " + timeSpan.ToString());
            
            // Parse
            System.Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
