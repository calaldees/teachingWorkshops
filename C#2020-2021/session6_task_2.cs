using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        int totalHours;
        int payRate;
        int deductions;
        int tax;
        int grossPay = 0;
        int netPay;

        //Input


        // Session6 Part A
        // We are again going to extend the Pay calculator. This time rather than entering the pay rate, the pay rate will be set by the job role the person does. They will select this from a simple menu system.
        // The roles and pay rates are shown below:
        // Role	Pay Rate per Hour
        // Cleaner	£7.00
        // Graduate Clerk	£11.25
        // Senior Clerk	£17.80
        // Prompt the user to enter a numeric code for the role of the person whose pay is being calculated. E.g. 1 for Cleaner, 2 for Graduate Clerk…
        //Use a switch statement to set the pay rate.
        const int PAY_RATE_PER_HOUR__CLEANER      = 700;
        const int PAY_RATE_PER_HOUR__CLERK        = 1125;
        const int PAY_RATE_PER_HOUR__SENIOR_CLERK = 1780;
        Console.WriteLine("1. Cleaner       : £"+PAY_RATE_PER_HOUR__CLEANER+"ph");
        Console.WriteLine("2. Graduate Clerk: £"+PAY_RATE_PER_HOUR__CLERK+"ph");
        Console.WriteLine("3. Senior Clerk  : £"+PAY_RATE_PER_HOUR__SENIOR_CLERK+"ph");
        Console.Write("Enter job number (1-3)");
        string jobType = "";
        switch (Console.ReadLine()) {
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
            default:
                jobType = "unknown";
                Console.WriteLine("Unknown job - manually enter payRate");
                Console.Write("payRate: ");
                payRate = int.Parse(Console.ReadLine());
                break;
        }
        
        Console.Write("totalHours: ");
        totalHours = Convert.ToInt32(Console.ReadLine());

        //Process

        // Session6 Part B
        // Now we will change the way that pay is calculated based on the role. 
        // Cleaners are paid at a flat rate for whatever number of hours they work.
        // Graduate Clerks are paid at single time (1xpayrate) for the first 35 hours they work, then at ‘time-and-a-half’ for the rest of the hours up to 50 hours. They are not allowed to work more than 50 hours per week.
        // Senior Clerks are paid at single time for the first 40 hours they work, then at double time for any and all remaining hours they work in the week.
        // Use nested conditional statements to calculate the appropriate pay for the role. Tax and other deductions are calculated as they were previously.
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

        // Part A
        // If the Gross Pay is less than £200, then tax is deducted at 10% of this, otherwise it is deducted at 10% for the first £200 and 25% on all earnings OVER the £200.  
        // Use an appropriate conditional statement to determine the tax calculation from the gross pay. Ensure the net pay is calculated correctly from the gross pay, tax and meal deductions.
        if (grossPay < 20000) {
            tax = grossPay * 10/100;
        }
        else {
            tax = 20000 * 10/100;
            tax = tax + ((grossPay-20000) * 25/100);
        }

        deductions = tax + 1000;  // Is 1000 the meal already?
        netPay = grossPay - deductions;

        // Session4 Part B
        // Now, we need to consider the meal deductions. Someone can only have meals at the restaurant on site (and hence have the £10 deductions in their pay packet), if their pay per hour would be at least the ‘minimum wage’ of £5 per hour after deductions.
        // a.	Add code to your programme that checks if someone is eligible for deductions. If they are, make the deduction automatically.
        // b.	Ensure that the user is informed clearly whether the deduction has been made. 
        int payRateAfterDeductions = netPay/totalHours;
        Console.WriteLine(payRateAfterDeductions);
        if (payRateAfterDeductions > 500) {
            int meals = 0;  // 1000

            // Session6 Part C
            // Now extend the section on meal deductions so that the user can opt into the meal deductions. 
            // Meal deductions are now based on the pay rate, so rather than being a flat rate of £10,
            // Cleaners get their meals for free; Graduate Clerks pay £10 and Senior Clerks pay £15 for the basic meal card or £25 for the executive dining club – which they can chose to opt into. However, they have to have earned at least £30 gross.
            // Use appropriate programming techniques to take account of this.
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

            // Session4 Part C
            // Now extend the section on meal deductions so that the user can opt into the meal deductions, if they are eligible. 
            // a.	Add code so that if the user is eligible to take meals, they enter a given digit if they want to opt in. 
            // b.	If the correct digit is entered, then deduct appropriately from their pay.
            Console.Write("You are eligable for meals. Do you want them, (Y/n): ");
            if (string.Equals("Y", Console.ReadLine())) {
                Console.WriteLine("Dedutions of meals " + meals);
                netPay = netPay - meals;
            }
        }

        //Output
        Console.Write("netPay: ");
        Console.WriteLine(netPay.ToString());
    }
}
