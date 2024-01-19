using System;
using System.Linq;

namespace _06_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string input=Console.ReadLine();
            string[] word = input.Split(" ");

            for(int i = 0; i < word.Length; i++)
            {
                char[] charArray= word[i].ToCharArray();
                int left = 0;
                int right = charArray.Length-1;
                while(left < right)
                {
                    char temp= charArray[left];
                    charArray[left] = charArray[right];
                    charArray[right] = temp;
                    left++;
                    right--;
                }
                Console.Write(new string (charArray)+ " ");
            }
        }
    }
}