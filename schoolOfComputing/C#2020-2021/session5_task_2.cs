using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        partA();
        partB();
        partC();
        partD();
        partE();
        partF();
    }

    /*
        Part A – increment by 1
        1
        2
        3
        4
    */
    void partA() {
        Console.WriteLine("partA");
        int x = 1;
        while (x <= 4) {
            Console.WriteLine(x);
            x += 1;
        }
    }

    /*
        Part B – increment by 2
        1
        3
        5
        7
        9
        11
    */
    void partB() {
        Console.WriteLine("partB");
        int x = 1;
        while (x <= 11) {
            Console.WriteLine(x);
            x += 2;
        }
    }

    /*
        Part C - doubling
        1
        2
        4
        8
        16
        32
    */
    void partC() {
        Console.WriteLine("partC");
        int x = 1;
        while (x <= 32) {
            Console.WriteLine(x);
            x = x * 2;
        }
    }

    /*
        Part D - Downwards
        10
        9
        8
        7
        6
        5
    */
    void partD() {
        Console.WriteLine("partD");
        int x = 10;
        while (x >= 5) {
            Console.WriteLine(x);
            x += -1;
        }
    }

    /*
        Part E  - Downwards pt 2
        3
        2
        1
        0
        -1
        -2
    */
    void partE() {
        Console.WriteLine("partE");
        int x = 3;
        while (x >= -2) {
            Console.WriteLine(x);
            x += -1;
        }
    }


    /*
        Part F
        A simple program is required to sum a sequence of integer numbers entered by the user. As soon as the user enters 0, the sum is to be displayed, and the program to complete.
        Hint: the code is in the lecture – enter it yourself to get used to writing while loops.
    */
    void partF() {
        Console.WriteLine("partF");
        int total = 0;
        int input = -1;
        while (input != 0) {
            Console.Write("Enter number to add (0 to exit): ");
            input = int.Parse(Console.ReadLine());
            total += input;
            Console.WriteLine("sum so far = " + total);
        }
        Console.WriteLine("Grand total: "+ total);
    }

}