using System;
namespace _03_leap_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year %400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if(year %4 == 0 && year % 100!=0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
               Console.WriteLine($"{year} is not a leap year");
            }
        }
    }
}