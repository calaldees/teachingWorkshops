using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        Console.WriteLine("Wildlife Park");

        const int PRICE_ADULT = 1490;
        const int PRICE_CHILD = 990;
        const int PRICE_SENIOR = 700;

        const int PRICE_GROUP = 900;  // per person (5 or more people)
        const int PRICE_PASS = 3990;  // (upto 5 if individual ticket are more expensive)

        //Console.Write("Family  (2 Adult + 3 Children): ");
        //int num_family = Convert.ToInt32(Console.ReadLine());

        Console.Write("Adult: ");
        int num_adult = Convert.ToInt32(Console.ReadLine());

        Console.Write("Child (under 16): ");
        int num_child = Convert.ToInt32(Console.ReadLine());

        Console.Write("Senior 	(over 65): ");
        int num_senior = Convert.ToInt32(Console.ReadLine());

        int total_num_tickets = num_adult + num_child + num_senior;
        int total_price;

        if (total_num_tickets > 5) {
            Console.WriteLine("Selling group tickets at *"+PRICE_GROUP);
            total_price = total_num_tickets * PRICE_GROUP;
        }
        else {
            total_price = 
                (num_adult * PRICE_ADULT) + 
                (num_child * PRICE_CHILD) + 
                (num_senior * PRICE_SENIOR)
            ;
            if (total_price > PRICE_PASS) {
                Console.WriteLine("Selling group pass");
                total_price = PRICE_PASS;
            }
            else {
                Console.WriteLine("Selling individual tickets adult:"+num_adult+" child:"+num_child+" senior:"+num_senior);
            }
        }

        Console.Write("Total: ");
        Console.WriteLine(total_price);
    }

}