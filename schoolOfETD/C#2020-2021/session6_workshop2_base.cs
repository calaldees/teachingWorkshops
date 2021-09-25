/*
Task2
-----

The zoo now wants a further version of the ticket program you wrote.
The park is now to offer different prices for the tickets based on time of entry and month of the year, as indicated by the tables below
The park opens at 9am and closes at different times in the year

Time	Month	Rate Card
Before mid day	October-March	3
Before mid day	April-June; September	2
Before mid day	July-August	1
Midday to 2pm	October-March	4
Midday to 3pm	April-June; September	3
Midday to 4pm	July-August	2
2pm to 3pm	October-March	5
3pm to 5pm	April-June; September	4
4pm to 7pm	July-August	3

Rate Card	Ticket	Price
1	Adult
Child
Senior
Pass
Group	14-90
10-90
9-90
39-90
9-00 per person
2	Adult
Child
Senior
Pass
Group	12-90
9-90
7-90
34-90
7-00 per person
3	Adult
Child
Senior
Pass
Group	9-90
7-90
6-90
29-90
6-00 per person
4	Adult
Child
Senior
Pass
Group	7-90
6-90
5-90
24-90
5-00 per person
5	Adult
Child
Senior
Pass
Group	5-90
3-90
3-40
14-90
4-00 per person

Implement this in C#!
Use a menu system to ask the user for the month, and then depending on the month given, a different menu for the time.
From this calculate the rate card to be used and then process the number of each type of ticket as before.

Hints:
1	You will need to set variables up for the prices for each ticket type and use these in the final calculation that will remain largely the same.
2	You will want to use a conditional statement for the selection of the card from the month and time – I would suggest you use the first conditional statement you were taught
2.a	This will be a nested set of conditionals
3	You will want to use a separate conditional statement to set the variables from (1) to the correct values for each rate card. I would suggest you use the conditional statement we learned this week.

Task3
-----
Using Real values rather than integers
Select an appropriate real data type for the prices of the tickets and convert the program to use these rather than int. You will need to change the data types, and the code and fixed values for it to work properly.


*/

using System;
class Program {
    static void Main(string[] args) {new Program();}
    Program() {

        // Input - Month and Time ------------------------------------------

        Console.Write("What month would you like to enter the park? Please enter 1-12: ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("What time would you like to enter the park? Enter the time using 24 hour clock, for example for 1pm write 1300: ");
        int time = int.Parse(Console.ReadLine());


        // Process - Set price of tickets ----------------------------------

        int adultPrice;
        int childPrice;
        int seniorPrice;
        int passPrice;
        int groupPrice;

        int rateCard = 0;  // Will be used in task

        // Hint - these will replaced by your case statements
        adultPrice = 1490;
        childPrice = 990;
        seniorPrice = 700;
        passPrice = 3990;
        groupPrice = 900;


        // Input - Ticket Sale ---------------------------------------------

        int numAdults = 0;
        int numChildren = 0;
        int numSeniors = 0;

        Console.Write("Enter number of Adults: ");
        numAdults = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Children: ");
        numChildren = int.Parse(Console.ReadLine());

        Console.Write("Enter number of Seniors: ");
        numSeniors = int.Parse(Console.ReadLine());

        // Process - Ticket Sale -------------------------------------------

        int totalTicketNumbers = 0;
        int totalSalePrice = 0;

        totalTicketNumbers = numAdults + numChildren + numSeniors;
        if (totalTicketNumbers >= 5)
        {
            //Sell group ticket
            Console.WriteLine("Selling group ticket at " + groupPrice.ToString () + " per person");
            totalSalePrice = groupPrice * totalTicketNumbers;
        }
        else
        {
            totalSalePrice = 
                (adultPrice * numAdults) + 
                (childPrice * numChildren) + 
                (seniorPrice * numSeniors);

            if (totalSalePrice > passPrice)
            {
                //Sell pass ticket
                Console.WriteLine("Selling Pass Ticket for " + passPrice .ToString ());
                totalSalePrice = passPrice;
            }
            else
            {
                Console.WriteLine("Selling Individual Tickets");
            }
        }

        // Output - Ticket Sale --------------------------------------------

        Console.Write("Total Sale Price = ");
        Console.WriteLine(totalSalePrice);

        // Output - Total Sales for the day --------------------------------

    }
}
