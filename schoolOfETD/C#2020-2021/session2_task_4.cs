using System;

class Task
{
    static void Main(string[] args)
    {
        Console.WriteLine("Grade Calculator");

        Console.WriteLine("Introduction to Milling	Class Test 20%	Assignment 80%");
        int intro_mill_class = Convert.ToInt32(Console.ReadLine());
        int intro_mill_assignment = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Wind and Wave	Assignment 50%	Exam 50%");
        int wind_assignment = Convert.ToInt32(Console.ReadLine());
        int wind_exam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Grain and Flour Theory	Assignment 50%	Assignment 50%");
        int grain_assignment1 = Convert.ToInt32(Console.ReadLine());
        int grain_assignment2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The Milling Professional	100% exam");
        int mill_exam = Convert.ToInt32(Console.ReadLine());

        int total;
        total = intro_mill_class + intro_mill_assignment + wind_assignment + wind_exam + grain_assignment1 + grain_assignment2 + mill_exam;

        Console.Write("Total: ");
        Console.WriteLine(total);

        int final = total / 4;
        Console.Write("Final: ");
        Console.WriteLine(final);
    }
}
