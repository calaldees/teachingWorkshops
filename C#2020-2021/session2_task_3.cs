using System;

class Task
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wildlife Park");

        Console.Write("Family  (2 Adult + 3 Children): ");
        int num_family = Convert.ToInt32(Console.ReadLine());

        Console.Write("Adult: ");
        int num_adult = Convert.ToInt32(Console.ReadLine());

        Console.Write("Child (under 16): ");
        int num_child = Convert.ToInt32(Console.ReadLine());

        Console.Write("Senior 	(over 65): ");
        int num_senior = Convert.ToInt32(Console.ReadLine());

        int total;
        total = (num_family * 3990) + (num_adult * 1490) + (num_child * 990) + (num_senior * 700);
        Console.Write("Total: ");
        Console.WriteLine(total);
    }
}
