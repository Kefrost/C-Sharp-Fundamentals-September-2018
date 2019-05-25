using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            AddNums(firstNum, secondNum);
            Console.WriteLine(SubstractNums(AddNums(firstNum, secondNum), thirdNum));
        }
        public static int AddNums(int a, int b)
        {
            int add = a + b;
            return add;
        }
        public static int SubstractNums(int a, int b)
        {
            int subs = a - b;
            return subs;
        }
    }
}
