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
        partG();
        partH();
        partI();
        partJ();
        partK();
    }

    void partA() {
        Console.WriteLine("partA");
        int loopCounterA = 0;
        while (loopCounterA < 10)
        {
            Console.WriteLine(loopCounterA.ToString());
            loopCounterA = loopCounterA + 1;
        }
        Console.WriteLine(loopCounterA.ToString());
    }

    void partB() {
        Console.WriteLine("partB");
        int loopCountB = 0;
        while (loopCountB < 10)
        {
            loopCountB = loopCountB + 1;
        }
        Console.WriteLine(loopCountB.ToString());
    }

    void partC() {
        Console.WriteLine("partC");
        int loopCountC = 12;
        while (loopCountC > 0)
        {
            loopCountC = loopCountC - 1;
            Console.WriteLine(loopCountC.ToString());
        }
        Console.WriteLine(loopCountC.ToString());
    }

    void partD() {
        Console.WriteLine("partD");
        int loopCountD = 0;
        int sumD = 0;
        while (loopCountD < 5)
        {
            sumD = sumD + 1;
            loopCountD = loopCountD + 1;
        }
        Console.WriteLine(sumD.ToString());
    }

    void partE() {
        Console.WriteLine("partE");
        int loopCountE = 0;
        int sumE = 0;
        while (loopCountE < 6)
        {
            sumE = sumE + 3;
            loopCountE = loopCountE + 1;
        }

        Console.WriteLine(sumE.ToString());

    }

    void partF() {
        Console.WriteLine("partF");
        int loopCountF = 0;
        int sumF = 0;
        while (loopCountF < 4)
        {
            sumF = sumF + loopCountF;
            loopCountF = loopCountF + 1;
        }

        Console.WriteLine(sumF.ToString());
    }

    void partG() {
        Console.WriteLine("partG");
        int loopCountG = 3;
        int sumG = 0;
        while (loopCountG < 9)
        {
            sumG = sumG + loopCountG;
            loopCountG = loopCountG + 2;
        }
        Console.WriteLine(sumG.ToString());
    }

    void partH() {
        Console.WriteLine("partH");
        int loopCountH = 9;
        int sumH = 0;
        while (loopCountH > 3)
        {
            sumH = sumH + loopCountH;
            loopCountH = loopCountH - 2;
        }
        
        Console.WriteLine(sumH.ToString());
    }

    void partI() {
        Console.WriteLine("partI");
        int loopCountI = 3;
        int sumI = 0;
        while (loopCountI < 36)
        {
            sumI = sumI + 2 * loopCountI;
            loopCountI = loopCountI * 2;
        }
        Console.WriteLine(sumI.ToString());
    }

    void partJ() {
        Console.WriteLine("partJ");
        int loopCountJ = 1;
        int product = 0;
        while (loopCountJ < 9)
        {
            product = product * loopCountJ;
            loopCountJ = loopCountJ + 2;
        }
        Console.WriteLine(product.ToString());
    }

    void partK() {
        Console.WriteLine("partK");
        int loopCountK = 1;
        int productA = 1;
        while (loopCountK < 6)
        {
            productA = productA * loopCountK;
            loopCountK = loopCountK + 1;
        }
        Console.WriteLine(productA.ToString());
    }


}