using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokeCount = 0;
            int originalPP = pokePower;
            double half = 0 ;
            if (originalPP % 2 == 0)
            {
                half = originalPP / 2.0;
            }
            while (pokePower >= distanceBetweenTargets)
            {
                pokePower -= distanceBetweenTargets;
                pokeCount++;
                if (half == pokePower)
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokeCount);
        }
    }
}
