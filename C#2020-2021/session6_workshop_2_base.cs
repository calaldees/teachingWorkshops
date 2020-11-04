using System;

namespace ZooCalcMonthTimeV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPrice = 0;

            // Input - Month and Time ------------------------------------------

            int month;
            int time;
            int rateCard = 0;

            Console.Write("What month would you like to enter the park? Please enter 1-12: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("What time would you like to enter the park? Enter the time using 24 hour clock, for example for 1pm write 1300: ");
            time = int.Parse(Console.ReadLine());


            // Process - Set price of tickets ----------------------------------

            int adultPrice;
            int childPrice;
            int seniorPrice;
            int passPrice;
            int groupPrice;

            adultPrice = 1490;
            childPrice = 990;
            seniorPrice = 700;
            passPrice = 3990;
            groupPrice = 900;


            // Input - Ticket Sale ---------------------------------------------

            int numAdults = 0;
            int numChildren = 0;
            int numSeniors = 0;
            int totalTicketNumbers = 0;

            int rawPrice = 0;  // salePrice

            Console.Write("Enter number of Adults: ");
            numAdults = int.Parse(Console.ReadLine());

            Console.Write("Enter number of Children: ");
            numChildren = int.Parse(Console.ReadLine());

            Console.Write("Enter number of Seniors: ");
            numSeniors = int.Parse(Console.ReadLine());

            // Process - Ticket Sale -------------------------------------------

            totalTicketNumbers = numAdults + numChildren + numSeniors;
            if (totalTicketNumbers >= 5)
            {
                //Sell group ticket
                Console.WriteLine("Selling group ticket at £" + groupPrice.ToString () + " per person");
                totalPrice = groupPrice * totalTicketNumbers;
            }
            else
            {
                rawPrice = adultPrice * numAdults + childPrice * numChildren + seniorPrice * numSeniors;
                if (rawPrice > passPrice)
                {
                    //Sell pass ticket
                    Console.WriteLine("Selling Pass Ticket for £" + passPrice .ToString ());
                    totalPrice = passPrice;
                }
                else
                {
                    Console.WriteLine("Selling Individual Tickets");
                    totalPrice = rawPrice;
                }
            }

            // Output - Ticket Sale --------------------------------------------

            Console.Write("Total Cost = ");
            Console.WriteLine(totalPrice);

            // Output - Total Sales for the day --------------------------------


        }
    }
}
