using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        //example0_problem();
        //example0();
        //example1();
        //example2();
        //example3();
        //example4();
        //example5_a();
        example5_b();
    }

    void example0_problem() {
        Console.WriteLine("exmaple0_problem");
        int number;

        number = int.Parse(Console.ReadLine());

        Console.Write("1 x ");
        Console.Write(number + "=");
        Console.WriteLine(number * 1);

        Console.Write("2 x ");
        Console.Write(number + "=");
        Console.WriteLine(number * 2);

        Console.Write("3 x ");
        Console.Write(number + "=");
        Console.WriteLine(number * 3);
    }
    void example0() {
        Console.WriteLine("exmaple0");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int x = 1;
        while (x <= 3) {
            Console.Write(x.ToString() +" x");
            Console.Write(number + "=");
            Console.WriteLine(number * x);
            x += 1;
        }
    }

    void example1() {
        Console.WriteLine("exmaple1");
        bool stayInWhile = true;
        while (stayInWhile)
        {
            Console.WriteLine("In the While Loop");
            stayInWhile = false;
        }
    }

    void example2() {
        Console.WriteLine("exmaple2");
        int loopCounter = 0;
        while (loopCounter < 10)
        {
            Console.Write("In the loop. Iteration: ");
            Console.WriteLine(loopCounter);
            loopCounter = loopCounter + 1;
        }
        Console.WriteLine("Left the Loop");
    }

    void example3() {
        Console.WriteLine("exmaple3");
        int total = 0;
        int userValue;
        Console.WriteLine("Enter a value. 0 to stop");
        userValue = int.Parse(Console.ReadLine());
        total = userValue;
        while (userValue != 0) {
            Console.WriteLine("Enter a value. 0 to stop");
            userValue = int.Parse(Console.ReadLine());
            total = total + userValue;
        }
        Console.WriteLine("Sentinel value entered.");
        Console.WriteLine("Total is: ");
        Console.WriteLine(total.ToString());
    }

    void example4() {
        string userWord;
        int count = 0;

        Console.WriteLine("Please enter the word 'Hello'");
        userWord = Console.ReadLine();

        while (userWord != "Hello" && count < 10)
        {
            Console.WriteLine("Please enter the word 'Hello'");
            userWord = Console.ReadLine();
            count = count + 1;
        }

        if (userWord == "Hello")
            Console.WriteLine("You entered the word!");
        else
            Console.WriteLine("You didn't enter \"Hello\"");

    }

    void example5_a() {
        int counter;
        counter = 0;
        while (counter < 10) {
            Console.WriteLine(counter);
            counter = counter + 1;
        }
    }

    void example5_b() {
        int counter = 0;
        while (counter != 10) {
            Console.WriteLine(counter);
            counter = counter + 3;
        }
    }

}