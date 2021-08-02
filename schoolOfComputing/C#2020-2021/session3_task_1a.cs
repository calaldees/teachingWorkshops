using System;

public class Task
{
    public static void Main(string[] args)
    {
        // Stock program
        
        int totalHours;
        int payRate;
        int deductions;
        int tax;
        int grossPay;
        int netPay;

        //Input             
        Console.WriteLine("Enter Hours");
        totalHours = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Pay Rate");
        payRate = int.Parse(Console.ReadLine());

        //Process
        grossPay = totalHours * payRate;
        tax = grossPay * 20 / 100;
        deductions = tax + 1000;
        netPay = grossPay - deductions;

        //Output
        Console.WriteLine(netPay.ToString());
    }
}
// 15 1000 = 11000
// 15 1001 = 11012
// 15 999 = 10988
// 1 9999 = 7000
// 1 10000 = 7000
// 1 10001 = 7001
