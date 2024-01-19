using System;
using System.Security.Cryptography.X509Certificates;

namespace _06_arr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 12, 8, -3, 15, 20, 0, 78, -15, -6, 30 };
            //get sum,min.
            //average
            Console.WriteLine(" sum: " + array.Sum());
            Console.WriteLine(" min: " + array.Min());

            Console.WriteLine(" sum: " + array.Average());
            Array.Sort(array);
            Array.Reverse(array);
            foreach( var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            array = new int[] { 12, -3, 1,20,0,78,-15 -6, 30 };
            //sum
            int sum = 0;
            for(int i =0; i<array.Length; i++)
            {
                sum += array[i];//summ= sum+array[i]
                Console.WriteLine("Sum: " + sum);
                Console.WriteLine("average: "+ sum/array.Length);

                //find minum
                int min = array[0];
                foreach( var item in array)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                Console.WriteLine("min: "+min);
                // sorting algoriith
                //
                //check from start , each adgestment --if 2nd is 
                for(int i=0; i<array.Length; i++)
                {// checks multiple times
                    for( int j =0;i<array.Length-1; j++) {
                        //check the array
                        if (array[j] > array[j+1])
                        {
                            int temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            //print array
                            foreach( var item in array)
                            {
                                Console.WriteLine("item:" + item);
                                Console.WriteLine();
                            }
                        }
                    }

                }
            }

        }
    }
}