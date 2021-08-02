using System;

public class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("You worked 40 hours");
        Console.WriteLine("Your payrate is 534p per hour");

        Console.Write("Your Gross Pay is ");
        Console.WriteLine(40 * 534);
        Console.Write("Deductions are ");
        Console.WriteLine(4000+1000);
        Console.Write("Your Gross Pay is");
        Console.WriteLine((40*534) -(4000+1000));

        //Console.ReadKey();
    }
}
