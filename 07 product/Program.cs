
using System;

namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!int.TryParse(Console.ReadLine(), out int N) || N <= 0)
                {
                    throw new FormatException();
                    return;
                }
                if (N == 1)
                {
                    Console.WriteLine("1");
                    return;
                }

                int result = 0;
                for (int digit = 9; digit >= 2; digit--)
                    while (N % digit == 0)
                    {
                        checked
                        {
                            result = result * 10 + digit;
                        }
                        N /= digit;
                    }

                if (N > 1)
                {
                    Console.WriteLine("No solution found.");
                    return;
                }

                int reversedResult = 0;
                while (result > 0)
                {
                    reversedResult = reversedResult * 10 + result % 10;
                    result /= 10;
                }

                Console.WriteLine(reversedResult);
            }
            catch (OverflowException)
            {
                Console.WriteLine("too large for this type");
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}