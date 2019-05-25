using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string chars = Console.ReadLine();
            PrintMiddleChar(chars);
        }
        public static void PrintMiddleChar(string chars)
        {
            int midChar = (chars.Length - 1) / 2;

            if (chars.Length % 2 != 0)
            {
                Console.WriteLine(chars[midChar]);
            }
            else
            {
                Console.WriteLine($"{chars[midChar]}{chars[midChar + 1]}" );

            }
        }
    }
}
