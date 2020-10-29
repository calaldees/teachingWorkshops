using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        Console.WriteLine("TimesTable Generator");
        timesTable(
            askInt("enter a number: "),
            askInt("how many times: ")
        );
    }

    int askInt(string msg) {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }

    void timesTable(int x, int times) {
        int count = 0;
        while (count <= times) {
            Console.WriteLine(x + " x " + count + " = " + (count * x));
            count += 1;
        }
    }

}