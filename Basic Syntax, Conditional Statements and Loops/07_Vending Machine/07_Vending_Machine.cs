using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            decimal total = 0;

            while (input != "start")
            {
                decimal coins = decimal.Parse(input);
                if (coins == 0.1m || coins == 0.2m || coins == 0.5m || coins == 1.0m || coins == 2.0m)
                {
                    total += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine().ToLower();
            }
            string product = Console.ReadLine().ToLower();
            while (input != "end")
            {
                if (product == "nuts" && total >= 2.0m)
                {
                    Console.WriteLine("Purchased nuts");
                    total -= 2.0m;
                }
                
                else if (product == "water" && total >= 0.7m)
                {
                    Console.WriteLine("Purchased water");
                    total -= 0.7m;
                }
                else if (product == "crisps" && total >= 1.5m)
                {
                    Console.WriteLine("Purchased crisps");
                    total -= 1.5m;
                }
                else if (product == "soda" && total >= 0.8m)
                {
                    Console.WriteLine("Purchased soda");
                    total -= 0.8m;
                }
                else if (product == "coke" && total >= 1.0m)
                {
                    Console.WriteLine("Purchased coke");
                    total -= 1.0m;
                }
                else if (product == "end")
                {
                    break;
                }
                else if (product != "nuts" && product != "water" && product != "crisps" && product != "soda" && product != "coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {total:F2}");
        }
    }
}
