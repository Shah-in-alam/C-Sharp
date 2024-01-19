using System;
namespace _06_array_2D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2d array

            int[,] ints = new int[4, 5];// = [{ 1,2}{}[,
            string[,] fruit = { { "apple", " pinapple", "lemon", "orange" },
                {"mango", "lime","banana", "watermelon" },{"pieach","grapefriut","strawberay","kiwi" } };
            //get values
            //keep in mind that we start at[0,0]
            Console.WriteLine($"element of row 1 col 1 :{fruit[0,0]}");
            Console.WriteLine($"element of row 2 col 1 : {fruit[1,0]}");
            fruit[1, 0] = "pear";
            Console.WriteLine($"element of row 2 col 1: {fruit[1, 0]}");
            //loop through array
            Console.WriteLine(fruit.Length);
            // length of all element
            Console.WriteLine("#rows :"+ fruit.GetLength(0) );
            Console.WriteLine("#colms :" + fruit.GetLength(1));
            //loop througth
            for( int i = 0; i < fruit.GetLength(0); i++ )
            {
                for( int j = 0; j < fruit.GetLength(1); j++)
                {
                    Console.WriteLine(fruit[i, j] + "\t");
                }
              //  Console.WriteLine();
            }
            Console.WriteLine();
            //random
            Random rd = new Random();
            for( int i =0; i<ints.GetLength(0); i++)
            {
                for( int j =0; j<ints.GetLength(1); j++)
                {
                    ints[i,j];
                }
            }
        }
    }
    
}