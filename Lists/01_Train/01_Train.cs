using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "end")
            {
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(input[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (int nums in wagons)
            {
                Console.Write($"{nums} ");
            }
            Console.WriteLine();
        }
    }
}
