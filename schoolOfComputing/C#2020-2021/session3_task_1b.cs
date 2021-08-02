using System;

public class Task
{
    public static void Main(string[] args)
    {
        // Modified stock program

        decimal totalHours;
        decimal payRate;
        decimal deductions;
        decimal tax;
        decimal grossPay;
        decimal netPay;

        //Input             
        Console.WriteLine("Enter Hours");
        totalHours = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter Pay Rate");
        payRate = decimal.Parse(Console.ReadLine());

        //Process
        grossPay = totalHours * payRate;
        tax = grossPay * 20 / 100;
        deductions = tax + 10.00m;
        netPay = Math.Round(grossPay - deductions, 2);

        //Output
        Console.WriteLine(netPay.ToString());
    }
}
// 15 10.00 = 110.00
// 15 10.01 = 110.12
// 15 9.99 = 109.88
// 1 99.99 = 69.992 **
// 1 100.00 = 70.00
// 1 100.01 = 70.008 **

// correction (round)
// 1 100.01 = 70.01
