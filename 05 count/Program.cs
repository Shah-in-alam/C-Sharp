using System;
namespace _05_count
{
    internal class Program
    {
        static void CountCharacterType(string str)
        {
            int vowels = 0, consonant = 0, others = 0, digit = 0;
            for( int i =0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsLetter(ch))
                {
                    ch = char.ToLower(ch);
                    if(!(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') && !(ch=='A' ||ch=='E'|| ch=='I'||ch=='O' ||ch=='U'))
                        consonant++;   
                  else 
                        vowels++; 
                }
                else if (char.IsDigit(ch))
                {
                    digit++;
                }
               else if (char.IsWhiteSpace(ch))
               {
                    
                }
                else
                {
                    others++;
                }
                    
            }
            Console.WriteLine("consonants: " + consonant);
            Console.WriteLine("vowels: " + vowels);
            Console.WriteLine("digits: " + digit);
            Console.WriteLine("other: " + others);
        }
        static void Main(string[] args)
        {
            Console.Write("");
            string str =Console.ReadLine();
            CountCharacterType(str);
        }
    }
}