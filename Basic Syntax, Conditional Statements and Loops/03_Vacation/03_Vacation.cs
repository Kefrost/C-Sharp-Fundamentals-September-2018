using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VacationWithArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int peoples = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            double total = 0;
            int rows = 0;
            double[,] grid = new double[3, 3] { {8.45, 9.80, 10.46 },{ 10.90, 15.60, 16 }, { 15, 20, 22.50 } };
            string typeIf = "Students";
            
            for (int i = 0; i < 3; i++)
            {
                if (type == typeIf)
                {
                    switch (day)
                    {
                        case "Friday":
                            price = grid[rows, 0];
                            break;
                        case "Saturday":
                            price = grid[rows, 1];
                            break;
                        case "Sunday":
                            price = grid[rows, 2];
                            break;
                    }
                }
                rows++;
                if (i == 0)
                {
                    typeIf = "Business";
                }
                if (i == 1)
                {
                    typeIf = "Regular";
                }
            }
            if (type == "Students" && peoples >= 30)
            {
                total = peoples * price * 0.85;
            }
            else if (type == "Business" && peoples >= 100)
            {
                total = (peoples - 10) * price;
            }
            else if (type == "Regular" && peoples >= 10 && peoples <=20)
            {
                total = peoples * price * 0.95;
            }
            else
            {
                total = peoples * price;
            }
            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}
