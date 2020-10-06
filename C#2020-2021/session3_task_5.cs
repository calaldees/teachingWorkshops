using System;

public class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Family Ticket Calculator 2");
        // Update stock code to decimal

        decimal numAdults;
        decimal numChildren;
        decimal numSenior;
        decimal numFamily;
        decimal totalPrice;

        Console.Write("Enter the number of Adults: ");
        numAdults = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the number of Children: ");
        numChildren = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the number of Seniors: ");
        numSenior = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the number of Family Tickets: ");
        numFamily = decimal.Parse(Console.ReadLine());

        totalPrice = 
            numAdults * 14.90m + 
            numChildren * 9.90m + 
            numSenior * 7.00m + 
            numFamily * 39.90m
        ;

        Console.WriteLine("Total Price:" + totalPrice.ToString());

        Console.ReadKey();
    }
}

