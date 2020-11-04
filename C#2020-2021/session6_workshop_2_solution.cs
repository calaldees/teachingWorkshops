using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZooCalcMonthTimeV1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numAdults = 0;
            int numChildren = 0;
            int numSeniors = 0;
            double totalPrice = 0.0;
            double rawPrice = 0.0;
            int totalTicketNumbers = 0;
            string temp = "";
            int month;
            int time;
            int rateCard = 0;
            double adultPrice;
            double childPrice;
            double seniorPrice;
            double passPrice;
            double groupPrice;


            // input -----------------------------------------------------------

            Console.WriteLine("What month would you like to enter the park? Please enter 1-12");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What time would you like to enter the park? Enter the time using 24 hour clock, for example for 1pm write 1300");
            time = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of Adults");
            temp = Console.ReadLine();
            numAdults = Convert.ToInt32(temp);

            Console.WriteLine("Enter number of Children");
            temp = Console.ReadLine();
            numChildren = Convert.ToInt32(temp);

            Console.WriteLine("Enter number of Seniors");
            temp = Console.ReadLine();
            numSeniors = Convert.ToInt32(temp);


            // process ---------------------------------------------------------

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
                    adultPrice = 14.90;
                    childPrice = 10.90;
                    seniorPrice = 9.90;
                    passPrice = 39.90;
                    groupPrice = 9.00;
                    break;

                case 2:
                    adultPrice = 12.90;
                    childPrice = 9.90;
                    seniorPrice = 7.90;
                    passPrice = 34.90;
                    groupPrice = 7.00;
                    break;

                case 3:
                    adultPrice = 9.90;
                    childPrice = 7.90;
                    seniorPrice = 6.90;
                    passPrice = 29.90;
                    groupPrice = 6.00;
                    break;

                case 4:
                    adultPrice = 7.90;
                    childPrice = 6.90;
                    seniorPrice = 5.90;
                    passPrice = 24.90;
                    groupPrice = 5.00;
                    break;

                case 5:
                    adultPrice = 5.90;
                    childPrice = 3.90;
                    seniorPrice = 3.40;
                    passPrice = 14.90;
                    groupPrice = 4.00;
                    break;

                default:
                    Console.WriteLine("Sorry, I don't recognise your choice");
                    Console.ReadLine();
                    return;
            }


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
                if (rawPrice > passPrice )
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

            // output ----------------------------------------------------------
            Console.Write("Total Cost = ");
            Console.WriteLine(totalPrice);

            // end -------------------------------------------------------------
            Console .WriteLine("Please Press Enter to finish");
            Console.ReadLine();

        }
    }
}
