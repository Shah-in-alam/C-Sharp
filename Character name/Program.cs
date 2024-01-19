using System;
namespace character_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            firstNameLength = firstName.Length;
            lastNameLength  = lastName.Length;
            Console.WriteLine($"{firstName} {lastName}, your first name has {firstNameLength} and your last name has {lastNameLength});
        }
    }
}