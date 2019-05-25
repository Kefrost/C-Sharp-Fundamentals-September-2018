using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintNxNTable(num);
        }
        public static void PrintNxNTable(int num)
        {
            for (int i = 0; i < num; i++)
            {
                for (int f = 0; f < num; f++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
