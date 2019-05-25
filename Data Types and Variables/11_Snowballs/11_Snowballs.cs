using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSnowballs = int.Parse(Console.ReadLine());
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
            BigInteger snowballValue = 0;
            int snowballSnowMax = 0;
            int snowballTimeMax = 0;
            int snowballQualityMax = 0;
            BigInteger snowballValueMax = 0;

            for (int i = 0; i < numOfSnowballs; i++)
            {
                snowballSnow = int.Parse(Console.ReadLine());
                snowballTime = int.Parse(Console.ReadLine());
                snowballQuality = int.Parse(Console.ReadLine());
                snowballValue = (snowballSnow / snowballTime);
                snowballValue = BigInteger.Pow(snowballValue, snowballQuality);

                if (snowballValue > snowballValueMax)
                {
                    snowballValueMax = snowballValue;
                    snowballSnowMax = snowballSnow;
                    snowballTimeMax = snowballTime;
                    snowballQualityMax = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowMax} : {snowballTimeMax} = {snowballValueMax} ({snowballQualityMax})");
        }
    }
}
