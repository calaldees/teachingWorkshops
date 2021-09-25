using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        partA();
        partB();
        partC();
    }

    void partA() {
        Console.WriteLine("partA");
        int[] myArray = new int[5];
        myArray[0] = 20;
        myArray[1] = 5;
        myArray[2] = 85;
        myArray[3] = 25;
        myArray[4] = 45;
        int loopCounter;
        for (loopCounter = 0; loopCounter < 5; loopCounter++)
        {
            Console.WriteLine("Number at this index is: " + myArray[loopCounter].ToString());
        }
    }

    void partB() {
        Console.WriteLine("partB");
        string[] myArray = new string[5];
        myArray[0] = "Baked Beans";
        myArray[1] = "Milk";
        myArray[2] = "Butter";
        myArray[3] = "Bread";
        myArray[4] = "Cheese";
        for (int loopCounter = 0; loopCounter < 5; loopCounter++)
        {
            Console.WriteLine("I need... " + myArray[loopCounter]);
        } 
    }

    void partC() {
        Console.WriteLine("partC");
        int[] myArray = new int[5];
        myArray[0] = 5;
        myArray[1] = 10;
        myArray[2] = 15;
        myArray[3] = 20;
        myArray[4] = 25;
        int total = 0;
        for (int loopCounter = 0; loopCounter < 5; loopCounter++)
        {
            total = total + myArray[loopCounter];
        }
        Console.WriteLine("The total is: " + total.ToString());
    }
}