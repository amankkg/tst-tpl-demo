using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace AsyncFileIO
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var from = "from.txt";
            var to = "to.txt";
            var sw = Stopwatch.StartNew();
            using (FileStream source = File.Open(from, FileMode.Open))
            {
                using (FileStream target = File.Open(to, FileMode.Open))
                {
                    await source.CopyToAsync(target);
                }
            }
            sw.Stop();
            Console.WriteLine(string.Format("{0:#,###,###.##}", sw.ElapsedMilliseconds));
        }
    }
}
