using System;
using System.IO;

namespace section9Files
{
    class Program
    {
        static void Main(string[] args)
        {

            // FILE
            // provides static methods, good for small number of operations and files -- every time does security check so better to use FileInfo object for larger file sets

            //COPY
            //2 parameters: source and destination which can't be directory or existing file
            //Can add bool to overwrite

            // var path = @"c:"
            File.Copy("/Users/owner/Documents/coding/myfile.jpg", "/Users/owner/Documents/myfile.jpg", true);
            
            //Verbatim sting @ to remove extra backslashes
            File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true)
            
            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }
            //reads the text and returns the content
            var content = File.ReadAllText(path);
            

            //FileInfo returns instance methods
            var fileInfo = new FileInfo(path);
            fineInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }

            // Directory.CreateDirectory(@"c:\temp\folder1");
            Directory.CreateDirectory(@"Users/owner/Documents/temp/folder1");

            //gets all files in dir ad subdirs

            // Directory.GetFiles(@"c:\project\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            Directory.GetFiles(@"Users/owner/Documents/", "*.*", SearchOption.AllDirectories);

            //gets all files in dir ad subdirs
            var files = Directory.GetFiles(@"Users/owner/Documents/", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
                {
                        System.Console.WriteLine(file);
                }

            //can specify file type
            var files = Directory.GetFiles(@"Users/owner/Documents/", "*.doc*", SearchOption.AllDirectories);
            foreach (var file in files)
                {
                        System.Console.WriteLine(file);
                }    

            //
            var directories = Directory.GetDirectories(@"Users/owner/Documents/", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                System.Console.WriteLine(directory);  
            }
            
            Directory.Exists("...");

            var directoryInfo = new DirecotryInfo("...");
            directoryInfo.GetFiles();
            //OR
            directoryInfo.GetDirectories();

            //PATH class
            var path = @"Users/owner/Documents/text/test.txt";
            //get file ext
            System.Console.WriteLine("Extension: " + Path.GetExtension(path));

            //get full file name
            System.Console.WriteLine("File name: " + Path.GetFileName(path));

            //get file name without ext
            System.Console.WriteLine("File name: " + Path.GetFileNameWithoutExtension(path));

            //get directory name
            System.Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));

        }
    }
}
