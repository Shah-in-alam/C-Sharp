using System;
namespace _05_wordnest
{
    internal class Program
    {
        static void Main(string[] args)
        {
          string startingOrd=Console.ReadLine();
          string  finalWord=Console.ReadLine();
            int count = 0;
            if(startingOrd !=finalWord) 
            {
                while (finalWord.Contains(startingOrd))
                {
                    int index= finalWord.IndexOf(startingOrd);  
                    count++;
                    finalWord= finalWord.Remove(index,startingOrd.Length);

                }
                int totalFound = count - 1;
                Console.WriteLine(totalFound);
            }
            else
            {
                Console.WriteLine(0);
            }

        }
    }
}