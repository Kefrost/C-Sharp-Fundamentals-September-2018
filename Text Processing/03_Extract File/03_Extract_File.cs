using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = Console.ReadLine().Split('\\').ToArray();
            string[] fileAndExtension = filePath[filePath.Length - 1].Split('.').ToArray();

            Console.WriteLine($"File name: {fileAndExtension[0]}");
            Console.WriteLine($"File extension: {fileAndExtension[1]}");
        }
    }
}
