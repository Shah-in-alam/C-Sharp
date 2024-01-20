using System;
namespace _07_squareroot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[,] matrix = new string[5, 5];
                for(int i = 0; i < 5; i++)
                {
                    string[] row = Console.ReadLine().Split(" ");
                    if (row.Length != 5)
                    {
                        throw new IndexOutOfRangeException();
                    }
                    for(int j = 0; j < 5; j++)
                    {
                        if (int.TryParse(row[j], out _))
                        {
                            throw new FormatException();
                        }
                        matrix[i, j] = row[j].ToLower();
                    }
                }
                for(int i = 0;i < 5; i++)
                {
                    for(int j=0; j < 5; j++)
                    {
                        if (matrix[i, j] != matrix[j,i] || matrix[i,j]!= matrix[4 -i,4-j] || matrix[i, j] != matrix[4 - i, 4 - j])
                        {
                            Console.WriteLine("This is Not a correct satorsquare");
                            return;
                        }
                    }
                }
                Console.WriteLine("This is a correct satorsquare5");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range or the problem with the array length");
            }
            catch (FormatException)
            {
                Console.WriteLine("You have entered a number or the input is wrong");
            }
            catch (Exception)
            {
                Console.WriteLine("crazy input");
            }
        }
    }
}