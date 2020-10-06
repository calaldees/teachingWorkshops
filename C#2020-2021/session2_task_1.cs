using System;

public class Task
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Picture frame calculator");
        int width;
        int height;
        int woodLength;
        int woodCost;

        Console.Write("Please enter width: ");
        width = Convert.ToInt32(Console.ReadLine());
        Console.Write("Please enter height: ");
        height = Convert.ToInt32(Console.ReadLine());

        woodLength = width * 2 + height * 2;
        Console.Write("woodLength: ");
        Console.WriteLine(woodLength);

        woodCost = 3 * woodLength;
        Console.Write("woodCost: ");
        Console.WriteLine(woodCost);
    }
}
