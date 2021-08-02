using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        int totalHours;
        int payRate;
        int deductions;
        int tax;
        int grossPay;
        int netPay;

        //Input
        Console.Write("totalHours: ");
        totalHours = Convert.ToInt32(Console.ReadLine());
        Console.Write("payRate: ");
        payRate = int.Parse(Console.ReadLine());

        //Process
        grossPay = totalHours * payRate;

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

        // Part B
        // Now, we need to consider the meal deductions. Someone can only have meals at the restaurant on site (and hence have the £10 deductions in their pay packet), if their pay per hour would be at least the ‘minimum wage’ of £5 per hour after deductions.
        // a.	Add code to your programme that checks if someone is eligible for deductions. If they are, make the deduction automatically.
        // b.	Ensure that the user is informed clearly whether the deduction has been made. 
        int payRateAfterDeductions = netPay/totalHours;
        Console.WriteLine(payRateAfterDeductions);
        if (payRateAfterDeductions > 500) {
            int meals = 1000;

            // Part C
            // Now extend the section on meal deductions so that the user can opt into the meal deductions, if they are eligible. 
            // a.	Add code so that if the user is eligible to take meals, they enter a given digit if they want to opt in. 
            // b.	If the correct digit is entered, then deduct appropriately from their pay.
            Console.Write("You are eligable for meals. Do you want the, (Y/n): ");
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
