using System;
namespace _06_even_and_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            string[] numberStr = input.Split(" ");
            for(int i = 0; i < numberStr.Length; i++)
            {
                int num = Convert.ToInt32(numberStr[i]);
                if (num % 2 == 0)
                {
                    Console.Write("Even "+" ");
                }
                else
                {

                    Console.Write("Odd" +" ");
                    
                }
            }
            Console.WriteLine();
        }
    }
}