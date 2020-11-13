using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        partA();
        partB();
        partC();
        partD();
        partE();
        //partF();
    }

    void partA() {
        Console.WriteLine("partA");
        int[] myArray = new int[2];
        myArray[0] = 20;
        myArray[1] = 5;
        Console.WriteLine(myArray[1].ToString());

    }

    void partB() {
        Console.WriteLine("partB");
        int[] myArray = new int[5];
        myArray[0] = 20;
        myArray[1] = 5;
        myArray[2] = 85;
        myArray[3] = 25;
        myArray[4] = 45;
        Console.WriteLine(myArray[4].ToString());
    }

    void partC() {
        Console.WriteLine("partC");
        int[] myArray = new int[5];
        myArray[0] = 20;
        myArray[1] = 5;
        myArray[2] = 85;
        myArray[3] = 25;
        myArray[4] = 45;
        Console.WriteLine((myArray[4] + myArray[1]).ToString());
    }

    void partD() {
        Console.WriteLine("part");
        int[] myArray = new int[5];
        myArray[0] = 20;
        myArray[1] = 5;
        myArray[2] = 85;
        myArray[3] = 25;
        myArray[4] = 45;
        Console.WriteLine((myArray[3] * 2).ToString());
    }

    void partE() {
        Console.WriteLine("part");
        string[] myArray = new string[5];
        myArray[0] = "Baked Beans";
        myArray[1] = "Milk";
        myArray[2] = "Butter";
        myArray[3] = "Bread";
        myArray[4] = "Cheese";
        Console.WriteLine("My shopping list for today is: " );
        Console.WriteLine(myArray[0] + " and " + myArray[3]);
    }

    void partF() {
        Console.WriteLine("part");
        int[] myArray = new int[5];
        for (int loopCounter = 0; loopCounter < 5; loopCounter++)
        {
            myArray[loopCounter] = int.Parse(Console.ReadLine());
        }

    }
}