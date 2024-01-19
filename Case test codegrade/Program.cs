using System;
namespace Case_test_codegrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Write("");
            Char inputChar = Console.ReadKey().KeyChar;
           
             Console.WriteLine();
            if (char.IsUpper(inputChar))
            {
                Console.WriteLine($"Uppercase");
            }
            else (char.IsLower(inputChar))
             {
                Console.WriteLine("Lowercase");
             }
        } 
    }
}