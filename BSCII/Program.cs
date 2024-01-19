using System;

class Program
{
    static void Main()
    {
        //Read an ingteger from the user 
        Console.Write("");
        int inputNumber = int.Parse(Console.ReadLine());
        // Converting integer in to a character
        char character = (char)inputNumber;
        Console.WriteLine(char.ToLower(character));
        Console.WriteLine(char.ToUpper(character));
        
    }
}