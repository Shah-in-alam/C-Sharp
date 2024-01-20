using System;
namespace _06_element_frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string ip=Console.ReadLine();
            char[] chArray = ip.ToCharArray();
            int[] count = new int[256];
            for( int i = 0; i < chArray.Length; i++ ) {
               char ch = chArray[i];
                count[ch]++;
            }
             for (int i=0; i < count.Length; i++ )
            {
                if(count[i] > 0)
                {
                    Console.WriteLine($" Character '{(char)i}' : {count[i]} times");
                }
            }       
        }
    }
}