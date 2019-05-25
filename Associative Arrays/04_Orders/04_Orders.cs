using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            var quantity = new Dictionary<string, double>();
            var prices = new Dictionary<string, double>();

            while (input[0] != "buy")
            {
                double price = double.Parse(input[1]);
                int quantityOfProducts = int.Parse(input[2]);
                if (!quantity.ContainsKey(input[0]))
                {
                    quantity[input[0]] = quantityOfProducts;
                    prices[input[0]] = quantityOfProducts * price;
                }
                else
                {
                    quantity[input[0]] += quantityOfProducts;
                    prices[input[0]] = quantity[input[0]] * price;
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
            foreach (var item in prices)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
