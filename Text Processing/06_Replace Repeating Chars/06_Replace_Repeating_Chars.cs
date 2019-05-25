using System;

namespace RemoveReplacingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string template = "";
            string result = input;
            for (int i = 0; i < input.Length; i++)
            {
                if (i != input.Length - 1)
                {
                    if (input[i] == input[i+1])
                    {
                        template += input[i];
                    }
                    else
                    {
                        if (template.Length > 0)
                        {
                            if (template.Length == 1)
                            {
                                string doubleChar = new string(template[0], 2);
                                int index = result.IndexOf(doubleChar);
                                result = result.Remove(index, 1);
                                template = "";
                            }
                            else
                            {
                                string charToReplace = template[0].ToString();
                                result = result.Replace(template, string.Empty);
                                template = "";
                            }
                        }
                    }
                }
                else if (template.Length > 0)
                {
                    if (template.Length == 1)
                    {
                        string doubleChar = new string(template[0], 2);
                        int index = result.IndexOf(doubleChar);
                        result = result.Remove(index, 1);
                        template = "";
                    }
                    else
                    {
                        string charToReplace = template[0].ToString();
                        result = result.Replace(template, string.Empty);
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
