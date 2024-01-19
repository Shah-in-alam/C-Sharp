using System;
namespace _05_duplicates
{
    internal class Program
    {
        static string RemoveDuplicates(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;   
            }
            string  result = input[0].ToString();
            for(int i = 1; i < input.Length; i++) 
            { 
                char currentChar = input[i];
                bool isDuplicate = false;
                for(int j=0;j<i; j++)
                {
                    if(currentChar == input[j]) { 
                    isDuplicate = true;
                    break;
                    }
                }
                if (!isDuplicate)
                {
                    result += currentChar;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("");
            string input= Console.ReadLine();
            string  output= RemoveDuplicates(input);
            Console.WriteLine(output);
        }
    }
}