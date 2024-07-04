using System;

namespace Triangle_Type_Identifier
{

  class Program
  {
   static void Main(string[] args)
    {
        Console.WriteLine("Triangle Type Identifier");
        Console.Write("Enter the length of side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("Triangle Type: Equilateral");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("Triangle Type: Isosceles");
        }
        else
        {
            Console.WriteLine("Triangle Type: Scalene");
        }
    }
  }
}

