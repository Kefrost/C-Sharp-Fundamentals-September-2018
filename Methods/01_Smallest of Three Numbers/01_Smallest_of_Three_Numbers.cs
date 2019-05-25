using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            PrintMinNum(a, b, c);
        }
        public static void PrintMinNum(int first, int second, int third)
        {
            int firstMin = Math.Min(first, second);
            int min = Math.Min(firstMin, third);
            Console.WriteLine(min);
        }
        
    }
}
