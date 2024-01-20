using System;
using System.Text.RegularExpressions;

namespace _05_duplicated
{
    internal class Program
    {
        static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }
            string result = input[0].ToString();
            for (int i = 0; i < input.Length; i++)
            {
                Char currentChar = input[i];
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (currentChar == input[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    result += currentChar;
                }
            }
            return result;

        }
        static void Mian(string[] args)
        {
            string input = Console.ReadLine();
            string output = RemoveDuplicates(input);
            Console.WriteLine(output);
        }
    }
}
