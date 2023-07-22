using System;
namespace Doviz
{
class Program
{
    static void Main()
    {
        Console.WriteLine("Choose one of the numbers");
            Console.WriteLine("1. USD -> UZS");
            Console.WriteLine("2. UZS -> USD");

             int number = Convert.ToInt32(Console.ReadLine());
            
            if(number == 1)
            {
              System.Console.WriteLine("USD to UZS");
        System.Console.Write("Enter the amount of USD:  ");
        decimal USD = Convert.ToDecimal(Console.ReadLine());
        System.Console.WriteLine("CONVERTING...");
        decimal UZS = USD*11630;
        System.Console.WriteLine(UZS);
            }

            else if(number == 2)
            {
                System.Console.WriteLine("USD to UZS");
        System.Console.Write("Enter the amount of UZS:  ");
        decimal UZS = Convert.ToDecimal(Console.ReadLine());
        System.Console.WriteLine("CONVERTING...");
        decimal USD = UZS/11630;
        System.Console.WriteLine(USD);
            }

            else
               Console.WriteLine("Invalid input");
    }
}
}