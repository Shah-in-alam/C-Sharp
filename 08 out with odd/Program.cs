using System;
using System.Collections.Generic;
using System.Linq;
namespace _08_out_with_odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ip = Console.ReadLine();
                int[] num = ip.Split(' ').Select(int.Parse).ToArray();
                Dictionary<int, int> count = new Dictionary<int, int>();
                foreach (int i in num)
                {
                    if (count.ContainsKey(i))
                    {
                        count[i]++;
                    }
                    else
                    {
                        count[i] = 1;
                    }
                }
                List<int> result = num.Where(i => count[i] % 2 == 0).ToList();
                string finalResult = string.Join(" ", result);
                Console.WriteLine(finalResult + " ");

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