using System;

namespace _03_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxAttempts = 3;
            int attempts = 0;
            int correctPin = Convert.ToInt32(Console.ReadLine()); // Read the correct PIN as the first input.

            while (attempts < maxAttempts)
            {
               // Console.WriteLine($"Enter your correct PIN:{enteredPin}");
                //Console.WriteLine("¶");
                int enteredPin = Convert.ToInt32(Console.ReadLine());

                if (enteredPin == correctPin)
                {
                    //Console.WriteLine($"Enter your correct PIN:{enteredPin}");
                    //Console.WriteLine($"Enter your PIN to withdraw money:{enteredPin}");
                    Console.WriteLine("Successful withdrawal");
                    break;
                }
                else
                {
                    attempts++;
                    if (attempts < maxAttempts)
                    {   
                        Console.WriteLine($"Enter your correct PIN: ");
                        Console.WriteLine($"Enter your PIN to withdraw money: ");
                        Console.WriteLine($"Enter your PIN again: ");
                        Console.WriteLine($"Enter your PIN again: ");

                        //Console.WriteLine("Enter your PIN to withdraw money: ");
                        // Console.WriteLine("¶");

                    }
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine("Too Many attempts");
            }
        }
    }
}
