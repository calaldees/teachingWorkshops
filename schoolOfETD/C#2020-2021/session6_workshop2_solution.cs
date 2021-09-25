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

        int rateCard = 0;
        switch (month)
        {
            // April-June; September
            case 4:
            case 5:
            case 6:
            case 9:

                if (time < 1200)
                {
                    rateCard = 2;
                }
                else if (time >= 1200 && time < 1500) // used to show combinations of conditions... but really only need to have the < 1500 as we already know its >= 1200 as the first condition hasn't 'executed'
                {
                    rateCard = 3;
                }
                else
                {
                    rateCard = 4;
                }
                break;

            //October-March
            case 10:
            case 11:
            case 12:
            case 1:
            case 2:
            case 3:

                if (time < 1200)
                {
                    rateCard = 3;
                }
                else if (time >= 1200 && time < 1400)
                {
                    rateCard = 4;
                }
                else
                {
                    rateCard = 5;
                }
                break;

            //July August
            case 7:
            case 8:

                if (time < 1200)
                {
                    rateCard = 1;
                }
                else if (time >= 1200 && time < 1600)
                {
                    rateCard = 2;
                }
                else
                {
                    rateCard = 3;
                }
                break;

            default:
                Console.WriteLine("Sorry, I don't recognise your choice");
                Console.ReadLine();
                return;

        }

        switch (rateCard)
        {
            case 1:
                adultPrice = 1490;
                childPrice = 1090;
                seniorPrice = 990;
                passPrice = 3990;
                groupPrice = 900;
                break;

            case 2:
                adultPrice = 1290;
                childPrice = 990;
                seniorPrice = 790;
                passPrice = 3490;
                groupPrice = 700;
                break;

            case 3:
                adultPrice = 990;
                childPrice = 790;
                seniorPrice = 690;
                passPrice = 2990;
                groupPrice = 600;
                break;

            case 4:
                adultPrice = 790;
                childPrice = 690;
                seniorPrice = 590;
                passPrice = 2490;
                groupPrice = 500;
                break;

            case 5:
                adultPrice = 590;
                childPrice = 390;
                seniorPrice = 340;
                passPrice = 1490;
                groupPrice = 400;
                break;

            default:
                Console.WriteLine("Sorry, I don't recognise your choice");
                Console.ReadLine();
                return;
        }


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
