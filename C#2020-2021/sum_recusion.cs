using System;

public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        //int i = int.Parse(Console.ReadLine());
        Console.WriteLine(
            //Sum(i)
            Sum(1)
        );
    }

    static int Sum(int n) {
        Console.WriteLine($"Sum({n})");
        if (n == 0) {
            return 0;
        }
        else {
            //return n + i//Sum(n-1);
            return n + Sum(askInt());
        }
    }





    public static int askInt(string msg = "Enter an Integer: ") {
        Console.Write(msg);
        return int.Parse(Console.ReadLine());
    }

}