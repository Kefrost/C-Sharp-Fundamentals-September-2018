using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double firstFact = Factorial(firstNum);
            double secondFact = Factorial(secondNum);
            double division = firstFact / secondFact;
            Console.WriteLine($"{division:F2}");
        }
        public static double Factorial(double a)
        {
            
            double sum = 1;
            
            for (int i = 1; i <= a; i++)
            {
                sum *= i;
                
            }
            return sum;
        }
    }
}
