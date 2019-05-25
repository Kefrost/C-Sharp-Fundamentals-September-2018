using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            while(num != 0)
            {
                int digit = num % 10;
                num = num / 10;
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
