using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        int a = 0;
        int b = 1;
        int n = 10;
        int temp;
        while (n > 0)
        {
            Console.WriteLine(a);
            temp = a;
            a = b;
            b = temp + b;
            n = n - 1;
        }
    }
}