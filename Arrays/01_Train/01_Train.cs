using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] nums = new int[countOfWagons];
            int sum = 0;
            for (int i = 0; i < countOfWagons; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                sum += nums[i];
            }
            foreach (int n in nums)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
