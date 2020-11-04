using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        partA();
        partB();
        partC();
        partD();
    }

    void partA() {
        int choice1 = 3;
        switch (choice1)
        {
            case 1:
            case 2:
                Console.WriteLine("A");
                break;
            case 3:
                Console.WriteLine("B");
                break;
            case 5:
            case 6:
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("D");
                break;
        }
    }

    void partB() {
        int choice2 = 5;
        switch (choice2)
        {
            case 1:
            case 2:
                Console.WriteLine("A");
                break;
            case 3:
                Console.WriteLine("B");
                break;
            case 5:
            case 6:
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("D");
                break;
        }
    }

    void partC() {
        int choice3 = 6;
        switch (choice3)
        {
            case 1:
            case 2:
                Console.WriteLine("A");
                break;
            case 3:
                Console.WriteLine("B");
                break;
            case 5:
            case 6:
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("D");
                break;
        }
    }

    void partD() {
        int choice4 = 4;
        switch (choice4)
        {
            case 1:
            case 2:
                Console.WriteLine("A");
                break;
            case 3:
                Console.WriteLine("B");
                break;
            case 5:
            case 6:
                Console.WriteLine("C");
                break;
            default:
                Console.WriteLine("D");
                break;
        }


    }

}