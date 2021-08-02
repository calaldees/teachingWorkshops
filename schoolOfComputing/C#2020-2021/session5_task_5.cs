// continued from session4_task_4.cs

using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        Console.WriteLine("Zoo Calculator - Wildlife Park Ticket System");
        Console.WriteLine("");

        const int PRICE_ADULT = 1490;
        const int PRICE_CHILD = 990;
        const int PRICE_SENIOR = 700;

        const int PRICE_GROUP = 900;  // per person (5 or more people)
        const int PRICE_PASS = 3990;  // (upto 5 if individual ticket are more expensive)


        // ---

        int total_num_adult = 0;
        int total_num_child = 0;
        int total_num_senior = 0;
        int total_sales = 0;

        string shop_open = "";

        while (shop_open != "y") {

            // ---

            Console.Write("Adult: ");
            int num_adult = int.Parse(Console.ReadLine());
            Console.Write("Child (under 16): ");
            int num_child = int.Parse(Console.ReadLine());
            Console.Write("Senior (over 65): ");
            int num_senior = int.Parse(Console.ReadLine());

            int num_tickets = num_adult + num_child + num_senior;
            int this_sale;

            if (num_tickets > 5) {
                Console.WriteLine("Selling group tickets at *"+PRICE_GROUP);
                this_sale = num_tickets * PRICE_GROUP;
            }
            else {
                this_sale = 
                    (num_adult * PRICE_ADULT) + 
                    (num_child * PRICE_CHILD) + 
                    (num_senior * PRICE_SENIOR)
                ;
                if (this_sale > PRICE_PASS) {
                    Console.WriteLine("Selling group pass");
                    this_sale = PRICE_PASS;
                }
                else {
                    Console.WriteLine("Selling individual tickets adult:"+num_adult+" child:"+num_child+" senior:"+num_senior);
                }
            }

            Console.Write("This Sale: ");
            Console.WriteLine(this_sale);

            // ---

            total_num_adult += num_adult;
            total_num_child += num_child;
            total_num_senior += num_senior;
            total_sales += this_sale;

            Console.WriteLine();
            Console.Write("Do you want to close the shop? [y/N]");
            shop_open = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("");
        Console.WriteLine("Totals Sales");
        Console.WriteLine("Adult: " + total_num_adult);
        Console.WriteLine("Child: " + total_num_child);
        Console.WriteLine("Senior: " + total_num_senior);
        Console.WriteLine("Total Sales: " + total_sales);

    }

}