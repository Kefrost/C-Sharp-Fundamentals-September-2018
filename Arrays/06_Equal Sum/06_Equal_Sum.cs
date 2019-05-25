using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                rightSum -= nums[i];
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
                leftSum += nums[i];
            }
            Console.WriteLine("no");
            
        }
    }
}
