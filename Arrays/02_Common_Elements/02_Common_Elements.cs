using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] elements = Console.ReadLine().Split(' ').ToArray();
            string[] elementsSecondRow = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < elementsSecondRow.Length; i++)
            {
                string temporary = elementsSecondRow[i];
                for (int n = 0; n < elements.Length; n++)
                {
                    if (temporary == elements[n])
                    {
                        Console.Write($"{temporary} ");
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
