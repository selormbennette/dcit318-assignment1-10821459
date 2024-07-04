using System;

namespace Grade_Calculator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade Calculator");
            Console.Write("Enter the numerical grade (0-100): ");
            double grade = Convert.ToDouble(Console.ReadLine());

                if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine("Letter Grade: A");
            }
                else if (grade >= 80 && grade <= 89)
            {
                Console.WriteLine("Letter Grade: B");
            }
                else if (grade >= 70 && grade <= 79)
            {
                Console.WriteLine("Letter Grade: C");
            }
                else if (grade >= 60 && grade <= 69)
            {
                Console.WriteLine("Letter Grade: D");
            }
                else if (grade < 60 && grade >= 0)
            {
                Console.WriteLine("Letter Grade: F");
            }
                else
            {
                Console.WriteLine("Invalid grade entered.");
            }
        }
    }
}