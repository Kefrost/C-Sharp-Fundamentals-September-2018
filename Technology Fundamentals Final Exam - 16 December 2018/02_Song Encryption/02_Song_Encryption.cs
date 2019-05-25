using System;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':');
            string encryptedStr = "";
            while (input[0] != "end")
            {
                bool valid = true;
                string artist = input[0];
                if (artist[0] < 65 || artist[0] > 90)
                {
                    valid = false;
                }
                for (int i = 1; i < artist.Length; i++)
                {
                    if (valid)
                    {
                        //97 122
                        if (artist[i] < 97 || artist[i] > 122 )
                        {
                            if (artist[i] != 39 && artist[i] != 32)
                            {
                                valid = false;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                if (valid)
                {
                    string song = input[1];
                    for (int k = 0; k < song.Length; k++)
                    {
                        if ((song[k] < 65 || song[k] > 90) && song[k] != 32)
                        {
                            valid = false;
                        }
                        if (!valid)
                        {
                            break;
                        }
                    }
                }
                if (!valid)
                {
                    Console.WriteLine("Invalid input!");
                    input = Console.ReadLine().Split(':');
                    continue;
                }
                else
                {
                    encryptedStr = "";
                    int key = input[0].Length;
                    if (artist[0] == 39 || artist[0] == 32)
                    {
                        encryptedStr += (char)artist[0];
                    }
                    else
                    {
                        int first = artist[0] + key;
                        if (first > 90)
                        {
                            int a = first - 90;
                            first = 64 + a;
                        }
                        encryptedStr += (char)first;
                    }
                    for (int i = 1; i < input[0].Length; i++)
                    {
                        int currChar = input[0][i];
                        if (currChar == 32 || currChar == 39)
                        {
                            encryptedStr += (char)currChar;
                        }
                        else
                        {
                            int increment = currChar + key;
                            if (increment > 122)
                            {
                                int a = increment - 122;
                                increment = 96 + a;
                            }
                            encryptedStr += (char)increment;
                        }
                    }
                    encryptedStr += '@';
                    for (int i = 0; i < input[1].Length; i++)
                    {
                        int currChar = input[1][i];
                        if (currChar == 32)
                        {
                            encryptedStr += (char)currChar;
                        }
                        else
                        {
                            int increment = currChar + key;
                            if (increment > 90)
                            {
                                int a = increment - 90;
                                increment = 64 + a;
                            }
                            encryptedStr += (char)increment;
                        }
                    }
                }
                Console.WriteLine($"Successful encryption: {encryptedStr}");
                input = Console.ReadLine().Split(':');
            }
        }
    }
}
