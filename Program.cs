using System;
namespace Doviz
{
class Program
{
    static void Main()
    {
        System.Console.WriteLine("USD to UZS");
        System.Console.Write("Enter the amount of USD:  ");
        decimal USD = Convert.ToDecimal(Console.ReadLine());
        System.Console.WriteLine("CONVERTING...");
        decimal UZS = USD*11630;
        System.Console.WriteLine(UZS);
    }
}
}