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

/*
e = double.PositiveInfinity;
e = double.NegativeInfinity;
e = double.Epsilon; //smallest +ve integer > 0
e = double.MaxValue; //big number
e = double.MinValue; //little
e = double.NaN; //not a number (e.g.0/0)
*/