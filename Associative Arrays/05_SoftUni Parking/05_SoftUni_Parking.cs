using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var carRegistration = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "register")
                {
                    if (carRegistration.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {carRegistration[input[1]]}");
                    }
                    else
                    {
                        carRegistration[input[1]] = input[2];
                        Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                    }
                }
                if (input[0] == "unregister")
                {
                    if (carRegistration.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} unregistered successfully");
                        carRegistration.Remove(input[1]);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
            }
            foreach (var item in carRegistration)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
