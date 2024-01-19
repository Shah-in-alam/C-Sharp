using System;

namespace Divide
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" ");
            string  a = Console.ReadLine();
            Console.Write(" ");
            string  b = Console.ReadLine();
           int num1 = int.Parse(a);
            int num2 = int.Parse(b); 
            if (num1 % num2== 0)
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