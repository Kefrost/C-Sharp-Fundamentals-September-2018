using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] input = Console.ReadLine().Split().ToArray();
            while (input[0] != "end")
            {
                if (input[0] == "Delete")
                {
                    nums.RemoveAll(item => item == int.Parse(input[1]));
                }
                else
                {
                    int element = int.Parse(input[1]);
                    int position = int.Parse(input[2]);
                    nums.Insert(position, element);
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
