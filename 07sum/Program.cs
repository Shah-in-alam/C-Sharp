using System;
namespace _07sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number=Convert.ToInt32(Console.ReadLine());
                if(number < 0)
                {
                    Console.WriteLine(5);

                }
                else if (number == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    int sum = 0;
                    for(int i = 0; i < number; i++)
                    {
                        sum += i * i;
                    }
                    Console.WriteLine(sum);
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