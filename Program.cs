﻿sing System;
namespace Doviz
{
    class Program
    {
        static void Main()
        {
              string answer = "";
            do
            {
                Console.WriteLine("Choose one of the numbers");
                Console.WriteLine("1. USD -> UZS");
                Console.WriteLine("2. UZS -> USD");

                String stringNumber = Console.ReadLine();
                int number = Convert.ToInt32(Console.ReadLine());
                
                if(number == 1)
                {
                   Console.WriteLine("USD to UZS");
                   Console.Write("Enter Amount USD: ");
                   decimal USD = decimal.Parse(Console.ReadLine());
                   Console.WriteLine("Converting from USD to UZS...");
                   decimal UZS =  11630 * USD;
                   Console.WriteLine($"{USD} USD = {UZS} UZS");
                }

                else if(number == 2)
                {
                   Console.WriteLine("UZS to USD");
                   Console.Write("Enter Amount UZS: ");
                   decimal UZS = decimal.Parse(Console.ReadLine());
                   Console.WriteLine("Converting from UZS to USD...");
                   decimal USD = UZS/11630;
                   Console.WriteLine($"{UZS} UZS = {USD} USD");
                }

                else
                   Console.WriteLine("Invalid input");

                 Console.WriteLine();
                 Console.Write("Do you want to Repeat? [y/n]: ");
               
                  answer = Console.ReadLine();
    
                 
            }

            while(answer=="");
        }
    }
}