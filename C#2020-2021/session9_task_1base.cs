using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // v 1.0 - with realistic tax deductions and meal card
            // 
            //Declare variables
            int payRate;
            int totalHours;
            int netPay;
            int grossPay;
            int deductions;
            int tax;
            int mealCard;

            Console.WriteLine("Welcome to the pay calculator" + System.Environment.NewLine);

            Console.WriteLine("Please enter in your hourly rate");
            payRate = int.Parse (Console.ReadLine());


            Console.WriteLine("Please enter in the number of hours that you have worked");
            totalHours = int.Parse(Console .ReadLine());

            grossPay = payRate * totalHours;

            //Test amount earnt and make tax deductions and rounddown to twod ecimal places
            if (grossPay  < 20000)
            {
                tax = grossPay / 10;
            }
            else
            {
                tax = (20000/10) + (grossPay -20000)/4;
            }

            deductions = tax;

            if ((grossPay - tax - 1000) / totalHours > 500)
            {
                //eligible for meal card 
                Console.WriteLine("Would you like a meal card? Enter 1 for yes, 0 for no");
                mealCard = int.Parse (Console.ReadLine());
                if (mealCard == 1)
                {
                    Console.WriteLine("Meal Card Selected");
                    deductions = deductions + 1000;
                }
                else
                {
                    Console.WriteLine("Meal Card not selected");
                }
            }


            netPay = grossPay - deductions;
            
            //Output
            Console.WriteLine("Total; " + netPay.ToString ());

            //Pause the program
            Console.ReadLine();
        }
    }
}
