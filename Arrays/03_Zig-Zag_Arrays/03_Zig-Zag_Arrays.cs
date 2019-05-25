using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] zigZagFirst = new int[rows];
            int[] zigZagSecond = new int[rows];
            int index = 0;
            for (int i = 1; i <= rows; i++)
            {
                int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    zigZagSecond[index] = tempArr[0];
                    zigZagFirst[index] = tempArr[1];
                }
                else
                {
                    zigZagFirst[index] = tempArr[0];
                    zigZagSecond[index] = tempArr[1];

                }
                index++;
            }
            foreach (int firstRow in zigZagFirst)
            {
                Console.Write($"{firstRow} ");
            }
            Console.WriteLine();
            foreach (int secondRow in zigZagSecond)
            {
                Console.Write($"{secondRow} ");
            }
            Console.WriteLine();
        }
    }
}
