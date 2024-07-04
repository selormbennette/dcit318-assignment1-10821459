using System;

namespace Ticket_Price_Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Ticket Price Calculator");
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        int standardTicketPrice = 10;
        int discountedTicketPrice = 7;

        if (age >= 65 || age <= 12)
        {
            Console.WriteLine($"Ticket Price: GHC {discountedTicketPrice}");
        }
        else
        {
            Console.WriteLine($"Ticket Price: GHC {standardTicketPrice}");
        }
    }
  }
}
