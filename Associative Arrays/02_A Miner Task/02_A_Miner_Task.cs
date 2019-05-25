using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> count = new Dictionary<string, int>();
            
            while (input != "stop")
            {
                if (count.ContainsKey(input))
                {
                    count[input] += int.Parse(Console.ReadLine());
                }
                else
                {
                    count[input] = int.Parse(Console.ReadLine());
                }
                input = Console.ReadLine();
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
