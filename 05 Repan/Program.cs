using System;
using System.IO;

namespace _05Files_Reading_DSPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //open text file and read through the contents of the whole document
            //either print out first then close, or other way around

            StreamReader input = File.OpenText("Rapunzel.txt");
            string text = input.ReadToEnd();
            input.Close();
            Console.WriteLine(text);


            //start to print the document again
            string rap = "Rapunzel.txt";
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream) //NOT end of the document
            {
                //string line = input.ReadLine();
                //Console.WriteLine(line);
                //OR
                Console.WriteLine("->" + input.ReadLine()); //prints out the doc and shows a new line is started in the doc
            }
            input.Close();


            //read through a doc char after char and let's add a blank space after each
            input = File.OpenText("Rapunzel.txt");
            while (!input.EndOfStream)
            {
                Console.Write((char)input.Read() + " ");
            }
            input.Close();


            //foreach through the whole text file
            foreach (string item in File.ReadLines("Rapunzel.txt"))
            {
                Console.WriteLine("--> " + item);
            }

            //loop through characters using a foreach
            foreach (char character in File.ReadAllText("Rapunzel.txt"))
            {
                Console.Write(character + "*");
            }

            Console.WriteLine();
            foreach (char c in "azerty")
            {
                Console.Write(c + "=");
            }

        }
    }
}