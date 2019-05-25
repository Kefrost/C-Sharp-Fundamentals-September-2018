using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeOfNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rangeOfNum; i++)
            {
                if (SumOfDigits(i) % 8 == 0)
                {
                    if (CheckIfNumHaveOddDigit(i) == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }  
        public static int SumOfDigits(int a)
        {
            int sum = 0;
            while (a > 0)
            {
                sum += a % 10;
                a = a / 10;
            }
            return sum;
        }
        public static bool CheckIfNumHaveOddDigit(int a)
        {
            int currentNum = 0;
            bool isTrue = false;
            while (a > 0)
            {
                 currentNum = a % 10;

                if (currentNum % 2 != 0)
                {
                    isTrue = true; ;
                }

                a = a / 10;
            }

            return isTrue;
        }
    }  
}
