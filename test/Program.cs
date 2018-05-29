using System;
using System.IO;

namespace section9Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //reads the text and returns the content
            var content = File.ReadAllText(@"/Users/owner/Documents/coding/test.txt");
            System.Console.WriteLine(content);
            
            

            // Directory.CreateDirectory(@"c:\temp\folder1");
            // Directory.CreateDirectory(@"Users/owner/Documents/temp/folder1");

            //gets all files in dir ad subdirs

            // Directory.GetFiles(@"c:\project\CSharpFundamentals", "*.*", .AllDirectories);
            // Directory.GetFiles(@"Users/owner/Documents/", "*.*", .AllDirectories);

            //gets all files in dir and subdirs
            var files = Directory.GetFiles(@"/Users/owner/Documents/coding/GoalKickerBooks", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                {
                        System.Console.WriteLine(file);
                }

            //can specify file type
            // var files = Directory.GetFiles(@"Users/owner/Documents/", "*.doc*", SearchOption.AllDirectories);
            // foreach (var file in files)
            //     {
            //             System.Console.WriteLine(file);
            //     }    

            // //
            // var directories = Directory.GetDirectories(@"Users/owner/Documents/", "*.*", .AllDirectories);
            // foreach (var directory in directories)
            // {
            //     System.Console.WriteLine(directory);  
            // }
            
            // Directory.Exists("...");

            // var directoryInfo = new DirecotryInfo("...");
            // directoryInfo.GetFiles();
            // //OR
            // directoryInfo.GetDirectories();

            // //PATH class
            // var path = @"Users/owner/Documents/text/test.txt";
            // //get file ext
            // System.Console.WriteLine("Extension: " + Path.GetExtension(path));

            // //get full file name
            // System.Console.WriteLine("File name: " + Path.GetFileName(path));

            // //get file name without ext
            // System.Console.WriteLine("File name: " + Path.GetFileNameWithoutExtension(path));

            // //get directory name
            // System.Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

        }
    }
}
