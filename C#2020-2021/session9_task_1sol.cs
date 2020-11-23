using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayCalc_StrIter
{
    class Program
    {
        static void Main(string[] args)
        {
            int jobRole = 0;           //1=Cleaner; 2=Grad Clerk; 3=Sen. Clerk
            int totalHours = 0;        //stores number of hours worked
            int normalHours = 0;       //number of 1x payrate hours
            int overTimeHours = 0;     //number of >1x payrate hours
            int overTimeHours2 = 0;
            decimal payRate = 0m;           //stores pay per hour in £
            decimal overtimeRate = 0m;      //stores rate of pay in £s per hour for overtime
            decimal overtimeRate2 = 0m;      //stores rate of pay in £s per hour for overtime at higher rates
            int cardChoice = 0;             //stores which meal card they ask for
            decimal mealCardPrice = 0m;     // price of the meal card
            decimal deductions = 0m;        //stores total of the deductions
            decimal grossPay = 0m;          //stored calculated pay before deductions
            decimal netPay = 0m;            //stored calculated pay after deductions
            decimal tax = 0m;


            //Input

            //Task 1.4
            string month;
            int weeksInMonth=0;
            while (weeksInMonth < 1)
            {
                Console.WriteLine("What month is it? (Enter first 3 letters of month)");
                month = Console.ReadLine();
                switch (month.ToLower())
                {
                    case "jan":
                    case "mar":
                    case "oct":
                    case "dec":
                        weeksInMonth = 5;
                        break;
                    case "feb":
                    case "apr":
                    case "may":
                    case "jun":
                    case "jul":
                    case "aug":
                    case "sep":
                    case "nov":
                        weeksInMonth = 4;
                        break;
                    default:
                        weeksInMonth = 0;
                        Console.WriteLine("Month Name not recognised...");
                        break;
                }
            }

            //end of Task 1.4

            Console.WriteLine("Please Enter the number of the job role");
            Console.WriteLine("1. Cleaner");
            Console.WriteLine("2. Graduate Clerk");
            Console.WriteLine("3. Senior Clerk");
            jobRole = Convert.ToInt32(Console.ReadLine());

            //Task 1.5

            totalHours = 0;
            for (int weekLoop = 1; weekLoop <= weeksInMonth; weekLoop++)
            {
                Console.WriteLine("Please Enter the number of hours worked in week {0}", weekLoop);
                totalHours += Convert.ToInt32(Console.ReadLine());
            }
            //end of task 1.5
            int meanHours = totalHours / weeksInMonth;

            switch (jobRole)
            {
                case 1: //cleaner
                    payRate = 7.00m;
                    normalHours = totalHours;
                    break;
                case 2: //Grad Clerk
                    payRate = 11.25m;
                    normalHours = Math.Min(35*weeksInMonth, totalHours);
                    if (totalHours > 35*weeksInMonth)
                    {
                        overTimeHours = totalHours - 35*weeksInMonth;
                    }
                    overtimeRate = payRate * 1.5m;
                    break;
                case 3: //Senior Clerk
                    payRate = 17.80m;
                    normalHours = Math.Min(40*weeksInMonth, totalHours);
                    //double time
                    if (totalHours > 40*weeksInMonth && totalHours < 48*weeksInMonth)
                    {
                        overTimeHours = totalHours - (40*weeksInMonth);
                    }
                    overtimeRate = payRate * 2;
                    //triple time
                    if(totalHours > 48 * weeksInMonth)
                    {
                        overTimeHours = 8 * weeksInMonth;
                        overTimeHours2 = totalHours - (48 * weeksInMonth);
                    }
                    overtimeRate2 = payRate * 3m;
                    break;
                default:
                    Console.WriteLine("Error! Invalid job role entered");
                    return;
               
            }

            //gross pay calculation
            grossPay = (normalHours * payRate) + (overTimeHours * overtimeRate) + (overTimeHours2*overtimeRate2);

            //tax calculation
            if (grossPay > (12000/52)*weeksInMonth)
            {
                //tax at 25% of over £500 and 10% of rest
                tax = (12000/52)*weeksInMonth / 10 + (grossPay - (12000/52)*weeksInMonth) / 4;
            }
            else
            {
                //tax is  10% of pay
                tax = grossPay / 10;
            }

            //check for meal card deduction


            if (grossPay > 30.00m*weeksInMonth)
            {
                //meal card deduction allowed
                if (jobRole == 2 || jobRole == 3)
                {
                    Console.WriteLine("Which Meal card do you want?");
                    Console.WriteLine("1. No meal card (free)");
                    Console.Write("2. Normal meal card: ");
                    if (jobRole == 3)
                    {
                        Console.WriteLine("£15");
                        Console.WriteLine("3. Executive Dining Club: £25");
                    }
                    else
                    {
                        Console.WriteLine("£10");
                    }

                    cardChoice = Convert.ToInt32(Console.ReadLine());
                }


                switch (jobRole)
                {
                    case 1:
                        mealCardPrice = 0;
                        Console.WriteLine("You have been given a free meal card");
                        break;
                    case 2:
                        if (cardChoice == 2)
                        {
                            mealCardPrice = 10.00m* weeksInMonth;
                            Console.WriteLine("You have been charged £10 per week for a meal card");
                        }
                        else
                        {
                            mealCardPrice = 0;
                            Console.WriteLine("You have not been charged for a meal card");
                        }
                        break;
                    case 3:
                        if (cardChoice == 2)
                        {
                            mealCardPrice = 15m*weeksInMonth;
                            Console.WriteLine("You have been charged £15 per week for a meal card");
                        }
                        else if (cardChoice == 3)
                        {
                            mealCardPrice = 25*weeksInMonth;
                            Console.WriteLine("You have been charged £25 per week for the Executive Dining Club");
                        }
                        else
                        {
                            mealCardPrice = 0;
                            Console.WriteLine("You have not been charged for a meal card");
                        }
                        break;
                }

                deductions = tax + mealCardPrice;

            }
            else
            {
                deductions = tax;
                Console.WriteLine("You have not earned enough to have a meal card");
            }


            netPay = grossPay - deductions;


            //Output
            Console.WriteLine("Your pay rate is " + payRate.ToString());
            Console.WriteLine("Your gross pay is " + grossPay.ToString());
            Console.WriteLine("Your deductions for tax are " + tax.ToString());
            Console.WriteLine("Your deductions for meal cards are " + mealCardPrice.ToString());
            Console.Write("Your net pay is: ");
            Console.WriteLine(netPay.ToString());

            Console.ReadLine();
        }
    }
}
