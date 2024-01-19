using System;
using System.IO;
namespace _05_Reading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPEAN TEXT FILE AND READS THROUGHT THE WHOLE DOC, EITHER PRITE OUT THEN 
            StreamReader input = File.OpenText("Rapunzel.txt");
            string text =input .ReadToEnd();
            input.Close();
            Console.WriteLine(text);
             Console.WriteLine($"# CHAR: {text.Length}");
            StreamReader sr = File.OpenText("Rapunzel.txt");
            string lines = sr.ReadToEnd();
            Console.WriteLine($"# lines : "+    lines.Length);

            //start to input 
            // input = File.OpeanText



            //
            string word = "";
            int countRapunzel = 0;
            foreach (char c in text.ToLower()) 
            {
                if (" asadadsadasasfasfasfsdf".Contains(c)) 
                {
                    word += c;
                }
                else
                {
                    if (word == "rapunzel")
                    {
                        countRapunzel++;
                    }
                }
            }
        }
    }
}