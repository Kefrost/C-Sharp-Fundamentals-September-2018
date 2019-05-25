using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicNum = int.Parse(Console.ReadLine());
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int n = i + 1; n < nums.Length;n ++)
                {
                    if (nums[i] + nums[n] == magicNum)
                    {
                        Console.WriteLine($"{nums[i]} {nums[n]}");
                    }
                }
            }
        }
    }
}
