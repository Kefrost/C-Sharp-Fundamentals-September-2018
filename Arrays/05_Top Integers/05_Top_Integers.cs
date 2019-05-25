using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = 0;
            List<int> result = new List<int>();
            for (int i = 0; i < integers.Length; i++)
            {
                if (integers[index] >= integers.Max())
                {
                    if (integers[index] != 0)
                    {
                        result.Add(integers[index]);
                    }
                    else if (index == integers.Length - 1)
                    {
                        result.Add(integers[index]);
                    }
                }
                
                integers[index] = 0;
                index++;
            }
            foreach (int nums in result)
            {
                Console.Write($"{nums} ");
            }
            Console.WriteLine();
        }
    }
}
