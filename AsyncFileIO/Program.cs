using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncFileIO
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var target = "target.txt";
            using (var targetStream = File.CreateText(target))
            {
                string line;

                do
                {
                    line = Console.ReadLine();
                    await targetStream.WriteLineAsync(line);
                }
                while (line != string.Empty);
            }
        }
    }
}
