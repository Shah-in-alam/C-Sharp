using System;
namespace _03_apply_form
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* an employee will recive a store from 0-100 and get a message
             * performace 90-100--> employee of the monthe 
             * for the past 7years of th company ,You are fired/51-
             * 61-70 you are well but some the 
             * 70-89 you are a 
             */
            Console.Write("Enter a number:");
            //int number;
           // bool  = int.TryParse(answer, out number);
            int  number =Convert.ToInt32(Console.ReadLine());
            if (  number >= 90 && number<=100)
            {
                Console.WriteLine("employee of the month");
            }
            else if (number > 0 && number< 50) 
            {
                Console.WriteLine("You lazy as did nothing all for the past this company, YOO ARE FIRED");
            }
            else if ( number >=51 && number<=60)
            {
                Console.WriteLine("Please better , youre the laughting in the working time");
            }
            else if ( number >=61 &&number < 70)
            {
                Console.WriteLine("You work well, but sometimes you are not serious0");
            }
            else if( number >=71 &&number < 89)
            {
                Console.WriteLine("yOU ARE AVERGAE, NOITHEIN SPECIAL");
            }
            else
            {
                Console.WriteLine(" GO TO HELL");
            }
        }
    }
}