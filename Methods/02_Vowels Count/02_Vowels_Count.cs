using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            PrintVowelsCount(word);
        }

        public static void PrintVowelsCount(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
