using System;

namespace _07_exception_before_after
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //old way handelling expetion
           /* Console.Write("Enter a file name:");
            string file= Console.ReadLine();
            Console.Write("Enter a lines:");
            int linner;
            if(!Int32.TryParse(Console.ReadLine(), out linner))
            {
                Console.WriteLine("Not valid linner! we stop");
                return;//returns input to the users
            }
            if(File.Exists(file))
            {
                string[] text = File.ReadAllLines(file);
                if(linner>text.Length)
                {
                    Console.WriteLine("Linner is big");
                    return;
                    
                }
                Console.WriteLine(text[linner]);
            }
            else
            {
                Console.WriteLine("File does not exists;");
                return;
            }*/
           // New way --> with exception
            
        }
    }
}