using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= num; rows++)
            {
                for (int i = 0; i < rows - 1; i++)
                {
                    Console.Write(rows + " ");
                }
                Console.WriteLine(rows);
            }
        }
    }
}
