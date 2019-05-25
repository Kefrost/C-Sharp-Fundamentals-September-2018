using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "End")
            {
                if (input[0] == "Add")
                {
                    nums.Add(int.Parse(input[1]));
                }
                if (input[0] == "Insert")
                {
                    nums.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
                if (input[0] == "Remove")
                {
                    if (int.Parse(input[1]) > nums.Count - 1)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(int.Parse(input[1]));
                    }
                }
                if (input[1] == "left")
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        nums.Add(nums[0]);
                        nums.RemoveAt(0);
                    }
                }
                if (input[1] == "right")
                {
                    for (int i = 0; i < int.Parse(input[2]); i++)
                    {
                        nums.Insert(0, nums[nums.Count - 1]);
                        nums.RemoveAt(nums.Count - 1);
                    }
                }
                input = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in nums)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
