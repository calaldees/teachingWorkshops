using System;

class Task
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculate Pay");
        Console.WriteLine("Reminder 1000 == £10");

        int totalHours;
        int payRate;
        int deductions;
        int grossPay;
        int netPay;
        int tax;

        Console.Write("enter totalHours: ");
        totalHours = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter payRate: ");
        payRate = Convert.ToInt32(Console.ReadLine());

        grossPay = totalHours * payRate;
        tax = grossPay / 5;
        deductions = tax + 1000;
        netPay = grossPay - deductions;

        Console.WriteLine(netPay.ToString());
    }
}
