using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;



namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate");

            int totalHours;
            int payRate;
            int deductions;
            int grossPay;
            int netPay;

            totalHours = Convert.ToInt32(Console.ReadLine());
            payRate = Convert.ToInt32(Console.ReadLine());

            grossPay = totalHours * payRate;
            deductions = 4000 + 1000;
            netPay = grossPay - deductions;

            Console.WriteLine(netPay.ToString());
        }
    }
}
