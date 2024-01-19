using System;
namespace CIRCUMFEREANCE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            int length =Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int answer = 2*(length+width);
            Console.WriteLine($"{answer}");
        }
    }
}