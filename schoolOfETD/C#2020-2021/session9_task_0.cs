using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        example1();
        example2a();
        example2b();
        example3();
        example4();
        example5();
    }

    void example1() {
        int loopCount = 1;
        while (loopCount <= 5)
        {
            Console.WriteLine(loopCount);
            loopCount++;
        }
    }

    void example2a() {
        // loop count scoped to loop
        for (int loopCount=1; loopCount <= 5; loopCount++) {
            Console.WriteLine(loopCount);
        }
        // Console.WriteLine(loopCount);  // ERROR!
    }
    void example2b() {
        // loop count scoped to function - available after loop
        int loopCount;
        for (loopCount=1; loopCount <= 5; loopCount++) {
            Console.WriteLine(loopCount);
        }
        Console.WriteLine(loopCount);
    }

    void example3() {
        int[] array = new int[]{0,1,2,3,4,5,6,7,8,9,10};
        for (int i=0; i<=10; i++) {
            for (int j = 0; j<=10; j++) {
                int result = array[i] + array[j];
                Console.Write(" "+result);
            }
        }
        Console.WriteLine();
    }

    void example4() {
        for (int i=0; i<=10; i++) {
            if (i < 5) {
                Console.WriteLine("i is less than 5");
            } else {
                Console.WriteLine("i is greater than 5");
            }
        }
    }

    void example5() {
        // I don't know what this is trying to do/prove?
        for (int i=0; i<=10; i++) {
            if (i<=10) {
                for (int j =0; j<10; j++) {
                    int result = i * j;
                }
            } else {
                for (int j = 0; j<10; j++) {
                    int result = i / j;
                }
            }
        }
    }
}