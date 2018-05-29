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
            // File.Copy("/Users/owner/Documents/coding/myfile.jpg", "/Users/owner/Documents/myfile.jpg", true);
            
            //Verbatim sting @ to remove extra backslashes
            // File.Copy(@"c:\temp\myfile.jpg", "d:\temp\myfile.jpg", true)
            
            // File.Delete(path);
            // if (File.Exists(path))
            // {
            //     //
            // }
            //reads the text and returns the content
            var content = File.ReadAllText(@"/Users/owner/Documents/coding/test.txt");
            System.Console.WriteLine(content);
        }
    }
}
