using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = "";

            char[] arr = user.ToCharArray();
            Array.Reverse(arr);
            string reverse = new string(arr);
            for (int i = 0; i < 4; i++)
            {
                pass = Console.ReadLine();
                if (pass == reverse)
                {
                    Console.WriteLine($"User {user} logged in.");
                    break;
                }
                else
                {
                    if (i == 3)
                    {
                        Console.WriteLine($"User {user} blocked!");
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                    }
                }
            }
        }
    }
}
