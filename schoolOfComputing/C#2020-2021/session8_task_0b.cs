using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        example1();
        //example2();
        //example3();
        example4();
        example5();
        example6();
        example7();
    }

    /*
    Array: An ordered collection of elements of the same type, the number of elements being fixed unless the array is *flexible
    */


    int[] example1() {
        Console.WriteLine("example1");
        int[] mySequence = new int[6];
        mySequence[0] = 2;
        mySequence[1] = 3;
        mySequence[2] = 5;
        mySequence[3] = 7;
        mySequence[4] = 11;
        mySequence[5] = 13;
        return mySequence;
    }

    void example2() {
        Console.WriteLine("example2");
        int[] mySequence = new int[6];
        // This is repetitious code!
        mySequence[0] = int.Parse(Console.ReadLine());
        mySequence[1] = int.Parse(Console.ReadLine());
        mySequence[2] = int.Parse(Console.ReadLine());
        mySequence[3] = int.Parse(Console.ReadLine());
        mySequence[4] = int.Parse(Console.ReadLine());
        mySequence[5] = int.Parse(Console.ReadLine());
    }

    void example3() {
        Console.WriteLine("example3");
        int[] mySequence = new int[6];
        for (int readLoop = 0; readLoop<6; readLoop++)
        {
            mySequence[readLoop] = int.Parse(Console.ReadLine());
        }
    }

    void example4() {
        Console.WriteLine("example4");
        int[] mySequence = example1();
        for (int sequenceCount=0; sequenceCount<6; sequenceCount++)
        {
            Console.WriteLine(mySequence[sequenceCount]);
        }
    }

    void example5() {
        Console.WriteLine("example5");
        int[] mySum = new int[5];
        mySum[0] = 1;
        for (int loopCount = 1; loopCount < 5; loopCount++)
        {
            mySum[loopCount] = mySum[loopCount - 1] * 2;
        }

        for (int loopCount = 0; loopCount < 5; loopCount++)
        {
            Console.WriteLine(mySum[loopCount]);
        }
    }


    void example6() {
        Console.WriteLine("example6");
        String[] employees = new String[4];
        employees[0] = "Dave";
        employees[1] = "Brian";
        employees[2] = "Phil";
        employees[3] = "Richard";
    }


    void example7() {
        /*
        Parallel 1d Arrays
        This concept of parallel arrays can be used to store heterogeneous data that is related
        Data of different types
        Data that is related to one entity is stored at the same index
        */
        Console.WriteLine("example7");
        String[] emp = new String[4];
        int[] empHours = new int[4];
        for (int loopCount = 0; loopCount < 4; loopCount++)
        {
            Console.Write("Please enter name: ");
            emp[loopCount] = Console.ReadLine();
            Console.Write("Please enter hours for " + emp[loopCount] + ": ");
            empHours[loopCount] = int.Parse(Console.ReadLine());
        }

    }
}

