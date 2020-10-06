using System;

public class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Volume of a cone - doubles");

        Console.Write("Please enter r: ");
        double r = double.Parse(Console.ReadLine());
        Console.Write("Please enter h: ");
        double h = double.Parse(Console.ReadLine());

        double v;
        v = Math.PI * r * r * h / 3;

        Console.Write("Volume is ");
        Console.WriteLine(v);
    }
}
