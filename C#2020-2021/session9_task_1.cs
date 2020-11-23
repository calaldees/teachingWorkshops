/*
Continued from session7_workshop2_task_3.cs


Workshop 9b – Using multiple constructs 
Dave Bennett
Task 1 – For Loops and revisiting calculations
This exercise is about being able to modify existing code and selecting the most appropriate programming construct to complete a task. 
Programmers in industry often have to change existing code and business scenarios change or the code is required to be more sophisticated and do more.
However, there will be different ways of doing the task and a programmer has to determine the most appropriate way of implementing this. 
Finally, they have to check that their code is working properly before they ask others to also check they are happy with it in some sort of code review.

1)	Download and extract (unzip) the project PayCalc_StrIter from Blackboard.
a.	Read through the code and re-familiarise yourself with it. This version uses job role as an input rather than pay rate and has overtime payments.

2)	Convert all variables and code based around using integers to calculate values in pennies to use decimal type variables and values based in £.

3)	It is, however, based around weekly pay rather than monthly pay.
4)	In the marked section add code to 
    a.	determine the month of the year from the user using string input and then
    b.	use the following table to determine the number of weeks in that month – storing the result in a integer variable weeksInMonth that you declare.
Month	Weeks in Month
Jan	5
Feb	4
Mar	5
Apr	4
May	4
Jun	4
Jul	4
Aug	4
Sep	4
Oct	5
Nov	4
Dec	5
Total	52
 

5)	In the marked section add code, using a for loop, to iterate through each week of that month, adding the weekly hours worked to the totalHours.

6)	Modify the pay calculation for each job as follows:
a.	Cleaner – standard pay rate throughout
b.	Grad Clerk – normal pay up to 35 hours per week MEAN AVERAGE (total hours in the month divided by weeks in month) and overtime above this
c.	Senior Clerk – normal pay up to 40 hours per week MEAN AVERAGE and double rate up to 48 hours per week, and triple time above this. (This will involve more modifications to the code.


7)	Modify the tax calculation so that it operates on the tax break from the low rate of 10% to the higher rate of 25% at £12,000 per annum of 52 weeks rather than £200 per week. This means you will have to again look at the number of weeks in the month and the pay and determine what the tax allowance would be for that month based on the £10,000 figure. (this is slightly higher than it is currently).
8)	Test your program now works by creating a set of 5 different test cases that you have calculated the correct answer using Excel, or a calculator and paper.
9)	For one of these create a trace table of the program dry run.
10)	Finally, show your code to another person in the class who has also done tasks 1-9 and get them to compare it with theirs. Where is it different? Why have you implemented the code in the way you have and which do you feel is better? You do not need to change your code, but reflect if there are any lessons to be learned. Make brief notes on this. Once you have done this show your code to your tutor.
*/
using System;
using System.Linq;  // for .Concat
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {

        int totalHours = 0;
        int payRate = 0;
        int deductions;
        int tax;
        int grossPay = 0;
        int netPay;

        // TASK
        // 4) In the marked section add code to 
        // a. determine the month of the year from the user using string input and then
        // b. use the following table to determine the number of weeks in that month – storing the result in a integer variable weeksInMonth that you declare.
        //
        // Input - Month -> Weeks in month
        int weeksInMonth = 0;
        string[] monthsWith5Weeks = new string[]{"jan", "mar", "oct", "dec"};
        string[] monthsWith4Weeks = new string[]{"feb", "apr", "may", "jun", "jul", "aug", "sep", "nov"};
        string[] months = monthsWith5Weeks.Concat(monthsWith4Weeks).ToArray();
        string month = askString("Enter a month: ", months);
        if (Array.IndexOf(monthsWith5Weeks, month) >= 0) {
            weeksInMonth = 5;
        }
        if (Array.IndexOf(monthsWith5Weeks, month) >= 0) {
            weeksInMonth = 4;
        }


        // Input Job Role

        const int PAY_RATE_PER_HOUR__CLEANER      = 700;
        const int PAY_RATE_PER_HOUR__CLERK        = 1125;
        const int PAY_RATE_PER_HOUR__SENIOR_CLERK = 1780;
        Console.WriteLine("1. Cleaner       : £"+PAY_RATE_PER_HOUR__CLEANER+"ph");
        Console.WriteLine("2. Graduate Clerk: £"+PAY_RATE_PER_HOUR__CLERK+"ph");
        Console.WriteLine("3. Senior Clerk  : £"+PAY_RATE_PER_HOUR__SENIOR_CLERK+"ph");
        string jobType = "";
        //switch (askInt("Enter job number (1-3)", 1, 3)) {
        switch (askString("Enter job number (1-3)", new string[]{"1", "2", "3"})) {
            case "1":
                jobType = "cleaner";
                payRate = PAY_RATE_PER_HOUR__CLEANER;
                break;
            case "2":
                jobType = "clerk";
                payRate = PAY_RATE_PER_HOUR__CLERK;
                break;
            case "3":
                jobType = "senior_clerk";
                payRate = PAY_RATE_PER_HOUR__SENIOR_CLERK;
                break;
            /* Not needed now input is validated
            default:
                jobType = "unknown";
                Console.WriteLine("Unknown job - manually enter payRate");
                Console.Write("payRate: ");
                payRate = int.Parse(Console.ReadLine());
                break;
            */
        }


        // TASK
        // 5)	In the marked section add code, using a for loop, to iterate through each week of that month, adding the weekly hours worked to the totalHours.
        // Mean hours per week
        for (int weekLoop = 1; weekLoop <= weeksInMonth; weekLoop++) {
            Console.WriteLine("Please Enter the number of hours worked in week {0}", weekLoop);
            totalHours += int.Parse(Console.ReadLine());
        }
        int meanHours = totalHours / weeksInMonth;
        Console.WriteLine("totalHours: "+totalHours+" meanHours:"+meanHours+" weeksInMonth:"+weeksInMonth+" month:"+month);
        //totalHours = askInt("totalHours: ");


        //Process

        // converted this to an if statement because it allows scoped variables
        if (jobType == "clerk") {
            // TASK
            // b. Grad Clerk – normal pay up to 35 hours per week MEAN AVERAGE (total hours in the month divided by weeks in month) and overtime above this
            int normalHoursMax = 35 * weeksInMonth;
            int normalHours = Math.Min(normalHoursMax, totalHours);
            int overtimeHours = Math.Max(0, totalHours - normalHoursMax);
            grossPay = (normalHours * payRate) + (int)(overtimeHours * payRate * 1.5);
            // TODO?
                //Console.WriteLine("Something is wrong - clerks cant work that long");
                // has this requirement been dropped?
        }
        else if (jobType == "senior_clerk") {
            // TASK
            // c. Senior Clerk – normal pay up to 40 hours per week MEAN AVERAGE and double rate up to 48 hours per week, and triple time above this. (This will involve more modifications to the code.
            int normalHoursMax = 40 * weeksInMonth;
            int doubleHoursMax = 48 * weeksInMonth;
            int normalHours = Math.Min(normalHoursMax, totalHours);
            int doubleHours = Math.Min(doubleHoursMax, totalHours - normalHoursMax);
            int tripleHours = Math.Max(0, totalHours - doubleHoursMax);
            grossPay = (normalHours * payRate) + (doubleHours * payRate * 2) + (tripleHours * payRate * 3);
        } else {
            grossPay = totalHours * payRate;
        }


        // 7)	Modify the tax calculation so that it operates on the tax break from the low rate of 10% to the higher rate of 25% at £12,000 per annum of 52 weeks rather than £200 per week. This means you will have to again look at the number of weeks in the month and the pay and determine what the tax allowance would be for that month based on the £10,000 figure. (this is slightly higher than it is currently).
        // Proccess - tax calculation
        int weekleyEarningThreshold = (12000/52) * weeksInMonth;
        if (grossPay > weekleyEarningThreshold) {
            tax = 
                (weekleyEarningThreshold * (10/100)) +   // base rate of 10% for first 12,000
                ((grossPay - weekleyEarningThreshold) * (25/100));  // tax at 25% of over
        }
        else {
            tax = grossPay * (10/100);  //tax is  10% of pay
        }


        // Meal Card Handling --------------------------------------------------

        int[] mealPrices = new int[3]{0, 0, -1};  // 0=NoMeals, 1=NormalMeals, 2=ExecutiveMeals
        // Set the value of the meals for the job role - unlock executive meals if needed
        switch (jobType) {
            case "cleaner":
                // meals are free - values are 0
                break;
            case "clerk":
                mealPrices[1] = 1000;
                break;
            case "senior_clerk":
                mealPrices[1] = 1500;
                mealPrices[2] = 2500;
                break;
        }
        int mealPrice = int.MinValue;
        int mealChoice = int.MinValue;
        while (mealPrice < 0) {
            Console.WriteLine("Which Meal card do you want?");
            Console.WriteLine("1. No meal card: "+mealPrices[0]);
            Console.WriteLine("2. Normal meal card: "+mealPrices[1]);
            Console.WriteLine("3. Executive meal card: "+mealPrices[2]);
            mealChoice = askInt("Enter an option: ", 1, 3) - 1;
            mealPrice = mealPrices[mealChoice];
        }
        switch (mealChoice) {
            case 0: Console.WriteLine("No Meals"); break;
            case 1: Console.WriteLine("Normal Meals at "+mealPrice); break;
            case 2: Console.WriteLine("Executive Meals at "+mealPrice); break;
        }


        // Final sum ...

        netPay = grossPay - tax - mealPrice;



        //Output
        Console.Write("netPay: ");
        Console.WriteLine(netPay.ToString());
    }

    // Copy&Paste from example_input.cs ----------------------------------------

    public static int askInt() {return askInt("input an integer: ");}
    public static int askInt(string msg) {return askInt(msg, 0, int.MaxValue);}
    public static int askInt(string msg, int min, int max) {
        while (true) {
            Console.Write(msg);
            int v = int.MinValue;
            try {
                v = int.Parse(Console.ReadLine());
            } catch (Exception) {
                continue;
            }
            if (v < min || v > max) {
                string error_msg = String.Format("Outside range {0} {1}", min, max);
                Console.WriteLine(error_msg);
                continue;
                //throw new System.IO.InvalidDataException(error_msg);
            }
            return v;
        }
    }

    public static string askString(string msg, string[] oneOf) {
        while (true) {
            Console.Write(msg);
            string input = Console.ReadLine();
            if (Array.IndexOf(oneOf, input) < 0) {
                Console.WriteLine(String.Join(",", oneOf));
                continue;
            }
            return input;
        }
    }

}
