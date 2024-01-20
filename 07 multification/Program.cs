using System;
namespace _07_multification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var dimention = Console.ReadLine().Split(" ");
                var dimention1 = dimention[0].Split("x");
                var dimention2 = dimention[1].Split("x");

                int r1 = int.Parse(dimention[0]);
                int cl1 = int.Parse(dimention[1]);
                int r2 = int.Parse(dimention[0]);
                int cl2 = int.Parse(dimention[1]);
                if (cl1 != r2)
                {
                    Console.WriteLine("wrong dimentions");
                    return;
                }
                int[,] matrix1 = new int[r1, cl1];
                int[,] matrix2 = new int[r2, cl2];
                int[,] result = new int[r1, cl2];

                for(int i = 0; i < r1; i++)
                {
                    var row = Console.ReadLine().Split(" ");
                    for(int j=0;j< cl1; j++)
                    {
                        matrix1[i, j] = int.Parse(row[j]);
                    }
                }
                for (int i = 0; i < r2; i++)
                {
                    var row = Console.ReadLine().Split(' ');
                    for (int j = 0; j < cl2; j++)
                    {
                        matrix2[i, j] = int.Parse(row[j]);
                    }
                }
                for (int i=0;i< r1; i++)
                {
                    
                    for(int j=0;j< cl2; j++)
                    {
                        for(int k=0;k< cl1; k++)
                        {
                            result[i, j] += matrix1[i, k] * matrix2[k, j];
                        }
                    }

                }
                for(int i=0;i< r1; i++)
                {
                    for(int j=0;j< cl2; j++)
                    {
                        Console.Write(result[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                    
            }
            catch (FormatException)
            {
                Console.WriteLine("converting problem");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("index out of range");
            }
            catch (OverflowException)
            {
                Console.WriteLine("tooo big for this type");
            }
            catch(Exception) {
                Console.WriteLine("crazy input");
            }
        }
    }
}