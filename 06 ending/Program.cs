using System;
using System.Linq;
namespace _06_ending
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string input= Console.ReadLine();
            string[] strings = input.Split(" ");
            int length = Math.Min(strings[0].Length, strings[1].Length);
            string commonEnding =string.Empty;
            for(int i=1; i<length; i++)
            {
                string end1 = strings[0].Substring(strings[0].Length -i);
                string end2 = strings[1].Substring(strings[1].Length -i);

                if(end1 == end2)
                {
                    commonEnding = end1;
                }
                
            }
            Console.WriteLine((string.IsNullOrEmpty(commonEnding) ? "None" : commonEnding));
        }
    }
    
}