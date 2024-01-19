using System;
using System.ComponentModel.Design;

namespace _04_even_steven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, end;
               
            if (int.TryParse(Console.ReadLine(), out start) && int.TryParse(Console.ReadLine(), out end))
            {
                long answer = 1;
                for(int i = start;i <= end; i++)
                {
                    if(i % 2 == 0 )
                    {
                        answer *= i;
                    }
                }
                Console.WriteLine(answer);
            }
            else
            {
             Console.WriteLine("Invalid input");
            }
        }
    }
}