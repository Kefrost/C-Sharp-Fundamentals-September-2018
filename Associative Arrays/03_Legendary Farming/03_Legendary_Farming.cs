using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LegendaryFarm
{
    class Program
    {
        static void Main(string[] args)
        {
            string Input = Console.ReadLine();
            var count = new Dictionary<string, int>();
            count.Add("shards", 0);
            count.Add("fragments", 0);
            count.Add("motes", 0);

            Dictionary<string, int> countJunk = new Dictionary<string, int>();

            string legendaryItem = null;
            bool shouldBreak = false;
            while (!string.IsNullOrEmpty(Input) && shouldBreak == false)
            {
               var newInput = Input.ToLower().Split().ToArray();
                for (int i = 1; i <= newInput.Length; i += 2)
                {
                    if (newInput[i] == "shards" || newInput[i] == "fragments" || newInput[i] == "motes")
                    {
                        count[newInput[i]] += int.Parse(newInput[i - 1]);
                    }
                    else if(countJunk.ContainsKey(newInput[i]))
                    {
                        countJunk[newInput[i]] += int.Parse(newInput[i - 1]);

                    }
                    else
                    {
                        countJunk[newInput[i]] = int.Parse(newInput[i - 1]);
                    }
                    if (count["shards"] >= 250)
                    {
                        legendaryItem = "Shadowmourne";
                        count["shards"] -= 250;
                        shouldBreak = true;
                        break;
                    }
                    else if (count["fragments"] >= 250)
                    {
                        legendaryItem = "Valanyr";
                        count["fragments"] -= 250;
                        shouldBreak = true;
                        break;
                    }
                    else if (count["motes"] >= 250)
                    {
                        legendaryItem = "Dragonwrath";
                        shouldBreak = true;
                        count["motes"] -= 250;
                        break;
                    }
                }
                Input = Console.ReadLine();
            }
            
            var resultCount = count.OrderByDescending(a => a.Value).ThenBy(a => a.Key);
            var resultJunk = countJunk.OrderBy(a => a.Key);
            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var item in resultCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in resultJunk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
