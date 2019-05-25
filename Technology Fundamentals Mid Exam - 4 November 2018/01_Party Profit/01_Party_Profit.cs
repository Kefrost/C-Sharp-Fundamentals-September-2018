using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;
            int coinsPerCompanion = 0;
            for (int i = 1; i <= days; i++)
            {
                bool party = false;
                
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                coins += 50 - (2 * partySize);
                if (i % 3 == 0)
                {
                    coins -= 3 * partySize;
                    party = true;
                }
                if (i % 5 == 0)
                {
                    coins += 20 * partySize;
                    if (party == true)
                    {
                        coins -= 2 * partySize;
                    }
                }
            }
            coinsPerCompanion = coins / partySize;
            Console.WriteLine($"{partySize} companions received {coinsPerCompanion} coins each.");
        }
    }
}
