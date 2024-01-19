using System;
using System.ComponentModel.Design;

class program
{
    static void Main()
    {


        //Read an integer from the user
       // Console.WriteLine("");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("True");
        }
      else
        {
            Console.Write(false);
        }
    }
}