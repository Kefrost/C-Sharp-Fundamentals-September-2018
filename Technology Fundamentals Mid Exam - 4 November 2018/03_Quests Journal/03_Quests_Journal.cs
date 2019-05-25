using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').ToList();
            var command = Console.ReadLine().Split('-').ToArray();
            input[0] = " " + input[0];
            while (command[0] != "Retire!")
            {
                if (command[0] == "Start ")
                {
                    if (!input.Contains(command[1]))
                    {
                        input.Add(command[1]);
                    }
                }
                if (command[0] == "Complete ")
                {
                    if (input.Contains(command[1]))
                    {
                        input.Remove(command[1]);
                    }
                }
                if (command[0] == "Side Quest ")
                {
                    string[] sideQuestCommand = command[1].Split(':').ToArray();
                    if (input.Contains(sideQuestCommand[0]))
                    {
                        string sideQuest = " " + sideQuestCommand[1];
                        if (!input.Contains(sideQuest))
                        {
                            int index = input.IndexOf(sideQuestCommand[0]);
                            input.Insert(index + 1, sideQuest);
                        }
                    }
                }
                if (command[0] == "Renew ")
                {
                    if (input.Contains(command[1]))
                    {
                        string renew = command[1];
                        input.Remove(command[1]);
                        input.Add(renew);
                    }
                }
                command = Console.ReadLine().Split('-').ToArray();
            }
            input[0] = input[0].Remove(0 ,1);

            for (int i = 0; i < input.Count; i++)
            {
                if (i == input.Count - 1)
                {
                    Console.Write($"{input[i]}");

                }
                else
                {
                    Console.Write($"{input[i]},");

                }
            }
            Console.WriteLine();
        }
    }
}
