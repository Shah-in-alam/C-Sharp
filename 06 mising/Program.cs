using System;
using System.Linq;

namespace _06_mising
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input_Number = Console.ReadLine();
            int[] numbers = input_Number.Split(" ").Select(int.Parse).ToArray();

            bool isValidInput = numbers.All(num => num >= 1 && num <= 9);

            if (!isValidInput)
            {
                Console.WriteLine("Please enter numbers from 1 to 9.");
                return;
            }

            int expectedSum = Enumerable.Range(1, 9).Sum();
            int actualSum = numbers.Sum();
            int missingNumber = expectedSum - actualSum;

            Console.WriteLine(missingNumber == 0 ? "There is no missing link" : missingNumber.ToString());
        }
    }
}
