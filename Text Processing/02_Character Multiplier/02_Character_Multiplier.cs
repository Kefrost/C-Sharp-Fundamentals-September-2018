using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string02
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            string first = input[0];
            string second = input[1];
            long sum = 0;
            int shortStr = Math.Min(first.Length, second.Length);

            for (int i = 0; i < shortStr; i++)
            {
                sum += first[i] * second[i];
            }
            string otherSymbols = "";

            if (first.Length > second.Length)
            {
                otherSymbols = first.Substring(shortStr);
            }
            else if (second.Length > first.Length)
            {
                otherSymbols = second.Substring(shortStr);
            }
            for (int i = 0; i < otherSymbols.Length; i++)
            {
                sum += otherSymbols[i];
            }
            Console.WriteLine(sum);
        }
    }
}
