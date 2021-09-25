/*
Introduction to C#: Class Test 
January 2021

Create a new Console Application called ‘CanterburyComputers’ and save this immediately to a location that you can later find.

Read through the following scenario and implement a solution to the problem described below.

Scenario

You have been recruited to design a computer program for a local computer company.
They want you to provide them with a C# console app to help them to sell three specific models of laptop.
They want to incentivise schools and businesses to buy these laptops for all their employees so they want to offer a larger discount when the customer makes a larger order.
They also want to offer an optional upgrade to the “deluxe package” of additional items including laptop case, external hard drive etc to match each laptop model.


| Model                      | Cost     | Deluxe Package |
|----------------------------|----------|----------|
| Dell Precision Workstation | £2800.00 | £3000.00 |
| Lenovo Thinkpad            | £1700.00 | £2000.00 |
| Apple MacBook Pro          | £2200.00 | £2500.00 |

|Number purchased|Discount|
|-|-|
|0-2|0%|
|3-10|10%|
|10+|15%|

Task - Create a program that:
1.	Declare a variable called Model of type String
2.	Prompt the user for the model of laptop they wish to purchase (‘D’, ’L’ or ‘A’) 
3.	Read the user’s answer into the model variable
4.	Declare a variable of type int to capture the number of laptops to be ordered 
5.	Prompt for the number of laptops and read the user’s input into the declared variable 
6.	Prompt the user if they wish to upgrade to the deluxe package and design your own procedure to store this information.
7.	Calculate the cost of the total order including the laptop model, number ordered and optional upgrade.
8.	Display the total price of the order to the user
9.	Prompt the user to press a key and wait for this to exit the program
 
Notes:

You do not have to worry about user data entry validation – i.e. the user will enter the right data type at the right time

Try to write this code in the most effective manner using the most suitable constructs of the C# language that you have been taught.

End of test.
*/

using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {

        // Input ---------------------------------------------------------------

        Console.Write("model of laptop they wish to purchase (‘D’, ’L’ or ‘A’): ");
        String laptop_model = Console.ReadLine();
        Console.Write("number of laptops to be ordered: ");
        int laptop_quantity = int.Parse(Console.ReadLine());
        Console.Write("delux (y/N): ");
        bool upgrade = Console.ReadLine() == "y";
        Console.WriteLine();

        // Process - Lookup prices ---------------------------------------------

        // I wanted to keep my _data_ separate from _logic_.
        // This should be a dictionary, but I am keeping to the constructs covered in this course.
        // I hate `switch` with a passion. We shouldn't be contaminating _logic_ to represent _data_.
        // I doubt many of the students would have taken this approach.
        String[] LOOKUP_laptop_model   = new String[] { "D",  "L",  "A"};
        int[]    LOOKUP_laptop_price   = new int[]    {2800, 1700, 2200};
        int[]    LOOKUP_laptop_upgrade = new int[]    { 200,  300,  300};

        // Effectively do a dictionary lookup of the index number
        int i;
        for (i = 0 ; i < LOOKUP_laptop_model.Length ; i++) {
            if (LOOKUP_laptop_model[i] == laptop_model) {break;}
        }

        // Process - Calculate total -------------------------------------------

        int laptop_price = LOOKUP_laptop_price[i];
        int laptop_price_upgrade = upgrade ? LOOKUP_laptop_upgrade[i] : 0;
        Console.WriteLine("Laptop Price: £" + laptop_price + " upgrade price: £" + laptop_price_upgrade);
        int total = (laptop_price + laptop_price_upgrade) * laptop_quantity;
        Console.WriteLine("Total (before bulk discount): £" + total);
        Console.WriteLine();

        // Apply % discount
        int discount = 0;
        if (laptop_quantity >= 3 && laptop_quantity <= 10) {
            Console.WriteLine("Order 3-10 - applying discount of 10%");
            discount += total/10;
        } else if (laptop_quantity > 10) {
            Console.WriteLine("Order 10+ - applying discount of 15%");
            discount += total/15;
        }
        Console.WriteLine("Total discount: £" + discount);
        Console.WriteLine();

        total -= discount;

        // Output --------------------------------------------------------------
        
        // I've kind of contaminated my output throught the program - I don't think this is unreasonable as it fits with the rest of the examples in the course.
        Console.WriteLine("Total: £" + total);
    }
}
