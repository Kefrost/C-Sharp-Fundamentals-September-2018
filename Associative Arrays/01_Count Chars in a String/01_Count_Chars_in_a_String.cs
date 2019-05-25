using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                string currentString = input[i];
                for (int f = 0; f < input[i].Length; f++)
                {
                    if (count.ContainsKey(currentString[f]))
                    {
                        count[currentString[f]]++;
                    }
                    else
                    {
                        count[currentString[f]] = 1;
                    }
                }
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
