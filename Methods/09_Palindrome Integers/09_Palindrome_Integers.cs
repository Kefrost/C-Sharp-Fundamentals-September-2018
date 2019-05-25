using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            while (input != "end")
            {
                string reverse = ReverseString(input);
                if (input == reverse)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            input = Console.ReadLine().ToLower();
            }

        }
        public static string ReverseString(string s)
        {
            string reverse = string.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverse += s[i];
            }
            return reverse;
        }
    }
}
