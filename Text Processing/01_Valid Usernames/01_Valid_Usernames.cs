using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string01
{
    class Program
    {
        static void Main(string[] args)
        {
            var usernames = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var validUsernames = new List<string>();
            for (int i = 0; i < usernames.Count; i++)
            {
                bool isItValid = true;
                string currentUsername = usernames[i];
                if (currentUsername.Count() > 2 && currentUsername.Count() < 17)
                {
                    for (int f = 0; f < currentUsername.Count(); f++)
                    {
                        if (currentUsername[f] > 47 && currentUsername[f] < 58 || currentUsername[f] > 64 && currentUsername[f] < 91 || currentUsername[f] > 96 && currentUsername[f] < 123 || currentUsername[f] == 45 || currentUsername[f] == 95)
                        {
                            continue;
                        }
                        else
                        {
                            isItValid = false;
                            break;
                        }
                    }
                    if (isItValid)
                    {
                        validUsernames.Add(currentUsername);
                    }
                }
            }
            foreach (var item in validUsernames)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
