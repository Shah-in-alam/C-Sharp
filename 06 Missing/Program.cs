using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int[] array = new int[numbers.Length];
        int index = 0;
        foreach (var number in numbers)
        {
            array[index++] = int.Parse(number);
        }

        Console.WriteLine(FindMissingNumber(array));
    }

    static string FindMissingNumber(int[] array)
    {
        int n = array.Length;
        int total = (n + 1) * (n + 2) / 2;  // The total sum of numbers from 1 to n+1

        foreach (var number in array)
        {
            total -= number;
        }

        if (total > n)
        {
            return "There is no missing link!";
        }
        else
        {
            return total.ToString();
        }
    }
}
