using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] specialNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int special = specialNums[0];
            int specialPower = specialNums[1];
            if (input.Contains(special))
            {
                while (true)
                {
                    int index = input.IndexOf(special);
                    int explode = index - specialPower;
                    if (explode < 0)
                    {
                        explode = 0;
                    }
                    int numsToRemove = specialPower * 2 + 1;
                    if (explode + numsToRemove > input.Count)
                    {
                        numsToRemove = input.Count - explode;
                    }
                    input.RemoveRange(explode, numsToRemove);
                    if (!input.Contains(special))
                    {
                        break;
                    }
                }
            }
            int sum = input.Sum();
            Console.WriteLine(sum);
        }
    }
}
