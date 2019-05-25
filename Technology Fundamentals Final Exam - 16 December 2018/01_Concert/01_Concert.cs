using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("; ", StringSplitOptions.RemoveEmptyEntries);
            var bandAndTime = new Dictionary<string, int>();
            var bandAndMembers = new Dictionary<string, List<string>>();
            int totalTime = 0;
            while (command[0] != "start of concert")
            {
                if (command[0] == "Play")
                {
                    int time = int.Parse(command[2]);
                    if (!bandAndTime.ContainsKey(command[1]))
                    {
                        bandAndTime.Add(command[1], time);
                        totalTime += time;
                    }
                    else
                    {
                        totalTime += time;
                        bandAndTime[command[1]] += time;
                    }
                }
                if (command[0] == "Add")
                {
                    var members = command[2].Split(", ", StringSplitOptions.RemoveEmptyEntries);
                    if (!bandAndMembers.ContainsKey(command[1]))
                    {
                        bandAndMembers.Add(command[1], new List<string>());
                        for (int i = 0; i < members.Length; i++)
                        {
                            if (!bandAndMembers[command[1]].Contains(members[i]))
                            {
                                bandAndMembers[command[1]].Add(members[i]);
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < members.Length; i++)
                        {
                            if (!bandAndMembers[command[1]].Contains(members[i]))
                            {
                                bandAndMembers[command[1]].Add(members[i]);
                            }
                        }
                    }
                }
                command = Console.ReadLine().Split("; ", StringSplitOptions.RemoveEmptyEntries);
            }
            var band = Console.ReadLine();
            Console.WriteLine($"Total time: {totalTime}");
            var sortedBandAndTime = bandAndTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            foreach (var item in sortedBandAndTime)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            Console.WriteLine($"{band}");
            foreach (var item in bandAndMembers[band])
            {
                Console.WriteLine($"=> {item}");
            }
        }
    }
}
