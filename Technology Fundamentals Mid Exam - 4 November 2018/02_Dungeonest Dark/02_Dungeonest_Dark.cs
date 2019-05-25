using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|').ToArray();
            int hp = 100;
            int coins = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string[] dungeon = input[i].Split().ToArray();
                if (dungeon[0] == "chest")
                {
                    coins += int.Parse(dungeon[1]);
                    Console.WriteLine($"You found {int.Parse(dungeon[1])} coins.");
                }
                else if (dungeon[0] == "potion")
                {
                    int healedHp = int.Parse(dungeon[1]);
                    if (hp + healedHp > 100)
                    {
                        healedHp = 100 - hp;
                        hp = 100;
                        Console.WriteLine($"You healed for {healedHp} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");

                    }
                    else
                    {
                        hp += healedHp;
                        Console.WriteLine($"You healed for {healedHp} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");
                    }    
                }
                else
                {
                    hp -= int.Parse(dungeon[1]);
                    if (hp > 0)
                    {
                        Console.WriteLine($"You slayed {dungeon[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {dungeon[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {hp}");
        }
    }
}
