using System;
namespace character_name
{
    internal class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
           int firstNameLength = firstName.Length;
           int lastNameLength = lastName.Length;
            Console.WriteLine($"{firstName} {lastName}, your first name has {firstNameLength} characters and your last name has {lastNameLength}");
        }
    }
}