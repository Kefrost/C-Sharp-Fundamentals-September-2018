using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine().ToLower();
            PrintIsPassValid(pass);
            
        }
        public static void PrintIsPassValid(string pass)
        {
            int digits = 0;
            int nonLetterAndDigitChars = 0;
            int count = 0;
            bool nonIsTrue = true;
            for (int i = 0; i < pass.Length; i++)
            {
                if ((pass[i] < 97 || pass[i] > 122) && (pass[i] < 48 || pass[i] > 57))
                {
                    nonLetterAndDigitChars++;
                }
                if (pass[i] > 47 && pass[i] < 58)
                {
                    digits++;
                }

            }
            if (pass.Length < 6 || pass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                count++;
                nonIsTrue = false;
            }
            if (nonLetterAndDigitChars > 0)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                count++;
                nonIsTrue = false;
            }
            if (digits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                count++;
                nonIsTrue = false;
            }
            if (nonIsTrue)
            {
                Console.WriteLine("Password is valid");

            }
        }
    }
}
