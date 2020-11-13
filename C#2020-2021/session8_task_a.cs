using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        partA();
        partB();
        partC();
        partD();
        partE();
        partF();
        partG();
        partH();
        partI();
        partJ();
    }

    void partA() {
        Console.WriteLine("partA");
        for (int loopCounterA = 0; loopCounterA < 10; loopCounterA = loopCounterA + 1)
        {
            Console.WriteLine(loopCounterA.ToString());
        }
    }
    void partB() {
        Console.WriteLine("partB");
        for (int loopCounterB = 0; loopCounterB < 10; loopCounterB++)
        {
            Console.WriteLine(loopCounterB.ToString());
        }
    }
    void partC() {
        Console.WriteLine("partC");
        for (int loopCounterC = 0; loopCounterC < 20; loopCounterC = loopCounterC + 2)
        {
            Console.WriteLine(loopCounterC.ToString());
        }
    }
    void partD() {
        Console.WriteLine("partD");
        for (int loopCounterD = 5; loopCounterD < 10; loopCounterD++)
        {
            Console.WriteLine(loopCounterD.ToString());
        }
    }
    void partE() {
        Console.WriteLine("partE");
        for (int loopCounterE = 10; loopCounterE >= 0; loopCounterE--)
        {
            Console.WriteLine(loopCounterE.ToString());
        }
    }
    void partF() {
        Console.WriteLine("partF");
        for (int loopCounterF = 10; loopCounterF >= 0; loopCounterF = loopCounterF - 2)
        {
            Console.WriteLine(loopCounterF.ToString());
        }
    }
    void partG() {
        Console.WriteLine("partG");
        int total = 0;
        for (int loopCounterG = 0; loopCounterG <= 5; loopCounterG++)
        {
            total = total + (loopCounterG * 2);
        }
        Console.WriteLine(total.ToString());
    }

    //Take your time with the next three and give them careful thought. 

    void partH() {
        Console.WriteLine("partH");
        int x = 3;
        int y = 2;
        int total = 0;
        for (int loopCounterH = 0; loopCounterH <= 5; loopCounterH++)
        {
            total = total + ((y + loopCounterH) * x);
        }
        Console.WriteLine(total.ToString());
    }
    void partI() {
        Console.WriteLine("partI");
        int loopCounterI;
        for (loopCounterI = 0; loopCounterI < 100000; loopCounterI++)
        {
            //nothing doing
        }
        Console.WriteLine(loopCounterI.ToString());
    }
    void partJ() {
        Console.WriteLine("partJ");
        int loopCounterJ;
        for (loopCounterJ = 0; loopCounterJ < 100000; loopCounterJ++)
        {
            //nothing doing
        }
        Console.WriteLine(loopCounterJ.ToString());
    }
}