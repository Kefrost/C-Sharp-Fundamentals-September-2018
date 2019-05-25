using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharsInRange(firstChar, secondChar);
        }

        public static void PrintCharsInRange(char a, char b)
        {
            
            for (int i = Math.Min(a, b) + 1; i < Math.Max(a, b); i++)
            {

                Console.Write($"{(char)i} ");
                
            }
            Console.WriteLine();
        }
    }
}
