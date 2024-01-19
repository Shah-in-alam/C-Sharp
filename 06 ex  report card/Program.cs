using System;
namespace _06_ex__report_card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Number of students: ");
            int students = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of tests : ");
            int tests = Convert.ToInt32(Console.ReadLine());
            double[,]reportCard = new double[students, tests];
            for( int  i= 0;i<students;i++ )
            {
                for (int j = 0; j < tests; j++)
                {
                    Console.Write($"Grade of tests{j + 1}of students{i + 1}: ");
                    reportCard[i, j] = Convert.ToDouble(Console.ReadLine());
                }
               
            }
            //average
            for( int i= 0; i<students;i++ )
            {
                double sum = 0;
                for( int j = 0;j < tests; j++)
                {
                    sum += reportCard[i, j];
                    
                }
                Console.WriteLine(sum/tests);
            }
            // test
            for( int  i =0;i<tests;i++ )
            {
                double sum  = 0;
                for(int j =0;j < students; j++)
                {
                    sum += reportCard[i, j];
                }
                Console.WriteLine(sum/students);
            }
        }
    }
}