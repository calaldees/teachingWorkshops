using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        part1();
        part2();
        part3();
        part4();
        part5();
        part6();
        part7();
        part8();
    }

    void part1() {
        Console.WriteLine("part1");
        Console.WriteLine("Before the loop");
        for (int loopCount=1; loopCount <= 10; loopCount++) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }


    /*
    1.	Run this code so you are sure it does what you expect it to.
    For each of the following, modify the code and then run it to make sure it works as you expect it to.
    2.	Now modify this code so the loop shows loopCounts  of 1 to 15
    3.	Now modify the code so the loop shows loopCounts of 0 to 7
    4.	Now modify the code so the loop shows loopCounts of 0, 3, 6, 9, 12 
    5.	Now modify the code so the loop shows loopCounts of 7 down to 2
    6.	Now modify the code so the loop shows loopCounts of 14, 10, 6, 2
    7.	Change the code back to how it originally looked (as above), but this time output using Console.WriteLine the values 0,2, 4, 6, 8, 10, 12, 14, 16, 18, 20
    */

    void part2() {
        Console.WriteLine("part2");
        Console.WriteLine("Before the loop");
        for (int loopCount=1; loopCount <= 15; loopCount++) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }

    void part3() {
        Console.WriteLine("part3");
        Console.WriteLine("Before the loop");
        for (int loopCount=0; loopCount <= 7; loopCount++) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }

    void part4() {
        Console.WriteLine("part4");
        Console.WriteLine("Before the loop");
        for (int loopCount=0; loopCount <= 12; loopCount+=3) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }

    void part5() {
        Console.WriteLine("part5");
        Console.WriteLine("Before the loop");
        for (int loopCount=7; loopCount >= 2; loopCount--) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }

    void part6() {
        Console.WriteLine("part6");
        Console.WriteLine("Before the loop");
        for (int loopCount=14; loopCount >= 2; loopCount+=-4) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }

    void part7() {
        Console.WriteLine("part7");
        Console.WriteLine("Before the loop");
        for (int loopCount=0; loopCount <= 20; loopCount+=2) {
            Console.WriteLine("In the loop. loopCount=" + loopCount.ToString());
        }
        Console.WriteLine("Left the Loop");
    }


    /*
    Part B – Creating a Times Table Program.

    8.	Now change the code so that you ask the user what times table they wish to view and show that times table. You will need an additional variable to store the timetable the user wishes to see.

    */
    void part8() {
        Console.WriteLine("part7");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        for (int loopCount=0; loopCount <= 12; loopCount++) {
            Console.WriteLine("" + loopCount + " * " + number + " = " + loopCount*number);
        }
    }

}