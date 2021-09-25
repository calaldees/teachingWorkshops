using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        question9();
    }

    void question9() {
        // bytes wrap round
        // Use civilisation ghandy
        Console.WriteLine("question9");
        byte current_age;
        byte next_age;
        Console.Write("What is your current age?");
        current_age = byte.Parse("255");  // Console.ReadLine()
        next_age = (byte)(current_age+1);  // the addition returns an int and needs to be cast back to byte manually
        Console.WriteLine("Next birthday you will be {0}", next_age);
    }
}