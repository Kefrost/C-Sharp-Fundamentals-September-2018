using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNum
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = int.Parse(Console.ReadLine());
             int fact = 1;
            int sum = 0;
            int strongNum = num;
            int digit = 0;
            while (num != 0)
            {
                digit = num % 10;
                num = num / 10;
                for (int i = 1; i <= digit; i++)
                {
                    fact = i * fact;
                }
                sum += fact;
                fact = 1;
                
            }
            if (strongNum == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
