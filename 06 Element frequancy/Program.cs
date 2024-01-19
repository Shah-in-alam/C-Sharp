using System;
namespace _06_Element_frequancy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip= Console.ReadLine();
            char[] charArray = ip.ToCharArray();
            int[] count = new int[256];
            for(int i=0; i<charArray.Length; i++)
            {
                char currentChar = charArray[i];
                count[currentChar]++;
            }
            for(int i=0; i<count.Length; i++)
            {
                if (count[i] > 0)
                {
                    Console.WriteLine($"Character '{(char)i}': {count[i]} times");
                }
            }
        }
    }
}