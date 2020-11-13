
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        example1();
        example2a();
        example2b();
        example3();
        //example4();
        example45();  // slide source was a mess
        example5();
        example6();
    }

    void example1() {
        Console.WriteLine("example1");
        /*
        for (<initialiser>; <test>; <increment>)
            <statement>
        */
        for (int loopCount=1; loopCount <= 5; loopCount++)
        {
            Console.WriteLine(loopCount);
        }
    }


    void example2a() {
        Console.WriteLine("example2a");
        for (int loopCount = 2; loopCount <= 7; loopCount++)
        {
            Console.WriteLine(loopCount);
        }
    }
    void example2b() {
        Console.WriteLine("example2b");
        int loopStart = 2;
        int loopEnd = 7;
        int loopCount;
        for (loopCount = loopStart; loopCount <= loopEnd; loopCount++)
        {
            Console.WriteLine(loopCount);
        }
    }

    void example3() {
        Console.WriteLine("example3");
        for (int loopCount = 2; loopCount <= 7; loopCount++)
        {
            Console.WriteLine(loopCount);
            loopCount += 1;
        }
    }

    void example4() {
        Console.WriteLine("example4");
        int loopStart = 2;
        int loopEnd = 7;
        for (int loopCount = loopStart; loopCount <= loopEnd; loopCount++)
        {
            Console.WriteLine(loopCount);
            loopEnd++;  // Infinate loop - the goalpost keeps being moved
        }
    }

    void example45() {
        Console.WriteLine("example45");
        // Jumps other than +1
        for (int loopCount = 2; loopCount <= 7; loopCount+=2)
        {
            Console.WriteLine(loopCount);
        }
    }

    void example5() {
        Console.WriteLine("example5");
        // will never show "Bing"
        for (int loopCount=11; loopCount<=10; loopCount++)
        {
            Console.WriteLine("Bing");
        }
    }

    void example6() {
        Console.WriteLine("example6");
        for(int loopCount=11; loopCount>=10; loopCount--)
        {
            Console.WriteLine("Bing");
        }
    }

}


