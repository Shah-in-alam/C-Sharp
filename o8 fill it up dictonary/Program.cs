
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _08_fill_up_the_dictionary
{
    internal class Program
    {
        static void Main()
        {

            try
            {
                var input = Console.ReadLine().Split(' ');
                var keyValuePairs = new Dictionary<int, int>();

                foreach (var pair in input)
                {
                    var parts = pair.Split('-').Select(int.Parse).ToArray();
                    keyValuePairs.Add(parts[0], parts[1]);
                }

                for (int key = 1; key <= 9; key++)
                {
                    if (!keyValuePairs.ContainsKey(key))
                    {
                        int missingValue = keyValuePairs[1] + (key - 1) * (keyValuePairs[2] - keyValuePairs[1]);
                        Console.WriteLine($"{key}-{missingValue}");
                        break;
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (OverflowException)
            {
                Console.WriteLine("too big for this type");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }

        }
    }
}