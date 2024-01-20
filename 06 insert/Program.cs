using System;
using System.Reflection;

namespace _06_insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string nu=Console.ReadLine();
            string[] number = nu.Split(" ");
            int insert = Convert.ToInt32(Console.ReadLine());
            
            bool inserted=false;
            for (int i=0; i<number.Length; i++)
            {
                int num = Convert.ToInt32(number[i]);
                if(!inserted && num>=insert)
                {
                    Console.Write(insert + " ");
                    inserted = true;
                }
                 Console.Write(num+" ");
            }
            if(!inserted)
            {
                Console.Write(inserted+" ");
            }
            Console.WriteLine();
        }
    }
}