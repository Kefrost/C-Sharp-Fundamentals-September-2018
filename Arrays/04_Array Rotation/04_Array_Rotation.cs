using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numsOfRotation = int.Parse(Console.ReadLine());
            int arrLenght = arr.Length;
            for (int i = 0; i < numsOfRotation; i++)
            {
                int index = 1;
                while (index < arrLenght)
                {
                    ReverseInt(arr, index - 1, index);
                    index++;
                }
            }
            foreach (int nums in arr)
            {
                Console.Write($"{nums} ");
            }
            Console.WriteLine();
        }
       public static void ReverseInt(int[] array, int i, int j)
        {
            int oldNum;
            oldNum = array[i];
            array[i] = array[j];
            array[j] = oldNum;
        }

    }
}
