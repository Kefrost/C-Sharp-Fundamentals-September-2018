using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace append
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();

            var result = new List<int>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                int[] currentArray = input[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < currentArray.Length; j++)
                {
                    result.Add(currentArray[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
