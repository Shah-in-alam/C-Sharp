using System;
using System.Diagnostics;

namespace _06_swaping
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input= Convert.ToInt32(Console.ReadLine());
            string[,] dou=new string[input,input];
            for(int i=0; i<dou.GetLength(0); i++)
            {
                string[] row = Console.ReadLine().Split(" ");
                for(int j=0;j<dou.GetLength(1); j++)
                {
                    dou[j,i] = row[j];
                }
            }
            string[,]swapArray=new string[input,input];
            for (int i = 0; i < input; i++)
            {
                for(int j=0;j<input; j++)
                {
                    swapArray[i, j] = dou[i, j];
                }
            }
            for(int i = 0;i<swapArray.GetLength(0); i++)
            {
                for(int j=0; j < swapArray.GetLength(1); j++)
                {
                    Console.Write(swapArray[i, j] + " ");
                }
                Console.WriteLine();
            }

            
        }
    }
}