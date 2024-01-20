
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string input = Console.ReadLine();
            string result;
            List<double> matchingNumbers = input.Split(',')
                .Select(part =>
                {
                    if (double.TryParse(part, out double num))
                    {
                        string numString = num.ToString();

                        if (numString.Contains('0') && numString[0] != '0')
                        {
                            return num;
                        }
                    }
                    return double.NaN;
                })
                .Where(num => !double.IsNaN(num))
                .OrderBy(num => num)
                .ToList();
            result = string.Join(" ", matchingNumbers);
            Console.WriteLine(result + " ");
        }
        catch (Exception)
        {
            Console.WriteLine("crazy input");
        }

    }
}