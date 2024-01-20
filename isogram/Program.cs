using System;
using System.Text.RegularExpressions;

namespace isogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string loweer = name.ToLower();
            bool iso = !Regex.IsMatch(loweer, @"(.).*\1");
            if(iso)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False"); 
            }
        }
    }
}