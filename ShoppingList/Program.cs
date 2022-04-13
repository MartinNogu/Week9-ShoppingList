using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string roootDirectory = @"C:\Users\Priit\source\samples";
            Console.WriteLine("Enter directory name:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Enter file name:");
            string fileName = Console.ReadLine();

            //File.Create($"{roootDirectory}\\{newDirectory}\\{fileName}");

            if (Directory.Exists($"{roootDirectory}\\{newDirectory}") && File.Exists($"{roootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{roootDirectory}\\{newDirectory}");
                File.Create($"{roootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}
