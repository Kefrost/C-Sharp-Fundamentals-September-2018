using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNum = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());
            string result = "";
            int numToAdd = 0;
            for (int i = bigNum.Length - 1; i >= 0; i--)
            {
                
                int currentNum = (int)char.GetNumericValue(bigNum[i]);
                int currentMultiply = (currentNum * multiplier) + numToAdd;
                if (i == 0)
                {
                    if (currentMultiply > 9)
                    {
                        int second = currentMultiply % 10;
                        int first = currentMultiply / 10;
                        int a = first;
                        first = second;
                        second = a;
                        string res = $"{first}{second}";
                        result += res;
                    }
                    else
                    {
                        result += currentMultiply;
                    }
                }
                else
                {
                    if (currentMultiply > 9)
                    {
                        int secondDigit = currentMultiply % 10;
                        result += secondDigit;
                        numToAdd = currentMultiply / 10;
                    }
                    else
                    {
                        result += currentMultiply;
                        numToAdd = 0;
                    }
                }
            }
            if (result.All(x => x == '0')) //if all string is 000000.... result = 0 

            {
                result = "0";
            }
            char[] charResult = result.ToCharArray();
            Array.Reverse(charResult);
            string newResult = new string(charResult);
            Console.WriteLine(newResult);
        }
    }
}
