using System;
namespace Book_text_reader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create an istance of stream Reader to read from file
            StreamReader reader = new StreamReader("Sarah.txt");
            int lineNumber = 0;
            //read first line from the text file
            String line=reader.ReadLine();
            //read other lines from the text file 
            while (line != null)
            {
                lineNumber++;
                Console.WriteLine(" line{0}'\n''\n'{1}",line,lineNumber);
                line= reader.ReadLine();
            }
            //close the resorce after having finished using it
            reader.Close();
        }
    }
}