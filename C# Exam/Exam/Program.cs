using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string questionName= Console.ReadLine();
            
            switch (questionName)
            {
                case "A1":
                    int lineNumber=Convert.ToInt32(Console.ReadLine());
                    int lineNum = CheckingLines(lineNumber[]); 
                    Console.WriteLine(lineNum);
                    break;
                case "B2":
                    string number = Console.ReadLine();
                    int n = Convert.ToInt32(int.Parse(number));
                    string  ints = checkingDivisor(n);
                    Console.WriteLine(ints);
                    break;
                case "C1":

                    break;

            }
        }
       public static string  CheckingLines(string[] lines)
        {
           string file = File.ReadAllText("sentences.txt");
           string[] getAll = File.ReadAllLines(file);
         
            for(int i = 0; i <getAll.Length;i++)
            {
                string line = getAll[i];
                if (char.IsLetter(line[0]))
                {
                    string seen=line.ToLower();
                    i++;
                    if (seen.Contains(line))
                    {
                        Console.WriteLine("It is an isogram");
                    }
                    else
                    {
                        Console.WriteLine("NOT an isogram");
                        Console.WriteLine(line);
                    }
                }
                else
                {
                    Console.WriteLine("crazy input");
                }
            }


            return file;
            
        }
        public  static int checkingDivisor(int [] number) {
            int numberAll= number[0];
           
            double multification= Math.Floor(Math.Pow(2, numberAll));
            int sum = 0;
            if (numberAll > 0)
            {
                
                if (numberAll % 2 == 0)
                {
                    int first = Convert.ToInt32(number[0]);
                    int second = Convert.ToInt32(number[1]);
                    sum += first + second;
                    if (sum == multification)
                    {
                        Console.WriteLine("Kaprekar number");
                    }
                    else
                    {
                        Console.WriteLine("NO kaprekar number");
                    }
                }
            }
            else
            {
                Console.WriteLine("crazy input");
            }
            return numberAll;
        }
        
    }
    
}