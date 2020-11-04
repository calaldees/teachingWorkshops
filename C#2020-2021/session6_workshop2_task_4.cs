/*
Task 4 – The Real Number Interest Calculator
Part A
Write a program that calculates the final amount of money in a building society bond which accrues interest. The initial amount (i), the number of years (n) and the interest rate (r) can vary and are input by the user.
The formula for the final amount at the end of the investment period (f) is given as:
f=i(1+r/100)^n

Use real numbers to store the values (doubles).

Part B
To display the final amount in a sensible fashion use the alternative version of the Console.WriteLine method described below.
E.g. 
  Console.WriteLine("Final Amount: {0:D} ", finalAmount.ToString("C2");

Look at how to format numbers using the help on ToString at:
http://msdn.microsoft.com/en-us/library/dwhawy9k(v=vs.110).aspx

Part C
Test the program with the following data.
Initial	Years	Rate	Final
1000	1	5%	1050
2287	5	7%	3207.636
15001.01	20	11.20%	125376.5
6534.36	4	3.05%	7368.771

NB: This table has not done any rounding.

*/

using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        Console.WriteLine("Interest Calculator");

        Console.Write("initial_amount: ");
        double i = double.Parse(Console.ReadLine());

        Console.Write("years: ");
        double n = double.Parse(Console.ReadLine());

        Console.Write("interest_rate (%): ");
        double r = double.Parse(Console.ReadLine());

        double f = i * Math.Pow(1 + (r/100), n);


        Console.WriteLine("Final Amount: {0:D} ", f.ToString("C2"));
    }
}
