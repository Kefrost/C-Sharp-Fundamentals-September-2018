using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int countCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countCommands; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input[2] == "going!")
                {
                    if (guests.Contains(input[0]) == false)
                    {
                        guests.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                if (input[2] == "not")
                {
                    if (guests.Contains(input[0]))
                    {
                        guests.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
                
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
