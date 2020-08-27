using System;
using System.IO;

namespace AsyncFileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var relativePath = ".";

            Console.WriteLine($"Working directory: \"{Path.GetFullPath(relativePath)}\"");

            Console.WriteLine("\nDirectories:");
            foreach (var directory in Directory.GetDirectories(relativePath))
                Console.WriteLine($"\t{directory}");

            Console.WriteLine("Files:");
            foreach (var filename in Directory.GetFiles(relativePath))
                Console.WriteLine($"\t{filename}");
        }
    }
}
