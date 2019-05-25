using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var cryptedText = "";
            for (int i = 0; i < input.Length; i++)
            {
                int firstChar = input[i];
                char charToReplace = (char)(firstChar + 3);
                cryptedText += charToReplace;
            }
            Console.WriteLine(cryptedText);
        }
    }
}
