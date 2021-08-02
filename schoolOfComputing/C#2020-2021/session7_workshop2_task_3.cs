using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {

        int totalHours;
        int payRate = 0;
        int deductions;
        int tax;
        int grossPay = 0;
        int netPay;

        //Input

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
        
        totalHours = askInt("totalHours: ");

        //Process

        switch (jobType) {
            case "clerk":
                if (totalHours <= 35) {
                    grossPay = totalHours * payRate;
                } else if (totalHours <= 50) {
                    grossPay = (35 * payRate) + (int)((totalHours-35) * payRate * 1.5);  // Note the cast!
                } else if (totalHours > 50) {
                    Console.WriteLine("Something is wrong - clerks cant work that long");
                }
                break;
            case "senior_clerk":
                if (totalHours <= 40) {
                    grossPay = totalHours * payRate;
                } else {
                    grossPay = (40 * payRate) + ((totalHours-40) * payRate * 2);
                }
                break;
            default:
                grossPay = totalHours * payRate;
                break;
        }

        if (grossPay < 20000) {
            tax = grossPay * 10/100;
        }
        else {
            tax = 20000 * 10/100;
            tax = tax + ((grossPay-20000) * 25/100);
        }


        // Meal Card Handling --------------------------------------------------

        // My original solution was based on payRateAfterDeductions
        // The solution I was given based this on job type? ...
        /*
        int payRateAfterDeductions = netPay/totalHours;
        Console.WriteLine(payRateAfterDeductions);
        if (payRateAfterDeductions > 500) {
            int meals = 0;  // 1000

            if (payRate > PAY_RATE_PER_HOUR__CLEANER && payRate <= PAY_RATE_PER_HOUR__CLERK) {
                meals = 1000;
            }
            if (payRate > PAY_RATE_PER_HOUR__CLERK && grossPay > 3000) {
                Console.Write("Do you want Executive Dining Club Meals for £25, (Y/n): ");
                if (string.Equals("Y", Console.ReadLine())) {
                    meals = 2500;
                } else {
                    meals = 1500;
                }
            }

            Console.Write("You are eligable for meals. Do you want them, (Y/n): ");
            if (string.Equals("Y", Console.ReadLine())) {
                Console.WriteLine("Dedutions of meals " + meals);
                netPay = netPay - meals;
            }
        }
        */


        /* 
        This was a provided solution ... it just feels armature ...
        Both the menu and the calculations have the logic duplicated
        I will attempt to use the reference below and rework this solution to something more maintainable

        if (grossPay > 3000)
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
                        mealCardPrice = 1000;
                        Console.WriteLine("You have been charged £10 for a meal card");
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
                        mealCardPrice = 1500;
                        Console.WriteLine("You have been charged £15 for a meal card");
                    }
                    else if (cardChoice == 3)
                    {
                        mealCardPrice = 2500;
                        Console.WriteLine("You have been charged £25 for the Executive Dining Club");
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
        */

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
