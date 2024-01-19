using System;
namespace _01_Uppercase
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("What's your first name? ");
            string name = Console.ReadLine();
            name = name.ToUpper();
            Console.WriteLine($" HELLO {name}");
        }
    }
}