/*

Relational operators


if (rawAverage >= 40 )
  Console.WriteLine("Passes Degree");
else
  Console.WriteLine("Fails Degree");
  Console.WriteLine("Doesn’t get graduate job");


*/

/*

if (rawAverage >= 40)
{
  Console.WriteLine("Passes Degree");
}
else
{
  Console.WriteLine("Fails Degree");
  Console.WriteLine("Doesn’t get graduate job");
}


*/


/*

int score;
int attemptsAtYear;
int year;

if (score < 40)
{
  if (attemptsAtYear > 1)
  {
    Console.WriteLine("Required to Withdraw");
  }
  else
  {
    Console.WriteLine("Offered Resits");
  }
}
else
{
  if (year == 3)
  {
    Console.WriteLine("Graduates");
  }
  else
  {
    Console.WriteLine("Proceeds to next year of Study");
  }
}


else is not mandatory


if… 
if… else…
if… else if… else…
Nested ifs

Nested
indentation not important for compiler
indentation IS important for human

or == ||
and == &&

*/

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
    }

    void partA() {
        int number; //Dim number As Integer
        number = 7;
        
        if (number == 7)
            Console.WriteLine("A:Yes");

        Console.WriteLine("Done");
    }

    void partB() {
        int numberB;
        numberB = 6;

        if ( numberB == 7 )
            Console.WriteLine("B:Yes");
    
        Console.WriteLine("Done");
    }

    void partC() {
        int numberC;
        numberC = 7;

        if (numberC == 7) 
            Console.WriteLine("C:Yes");
            Console.WriteLine("C:Yes!");
    
        Console.WriteLine("Done");

        numberC = 6;

        if (numberC == 7) 
            Console.WriteLine("C2:Yes");
            Console.WriteLine("C2:Yes!");
    
        Console.WriteLine("Done");
    }

    void partD() {
        int numberD;
        numberD = 7;

        if (numberD == 7)
            Console.WriteLine("D:Yes");
        else
            Console.WriteLine("D:No");
        
        Console.WriteLine("Done");

        if (numberD == 6)
        {
            Console.WriteLine("D2:Yes");
            Console.WriteLine("D2:Yes!");
        }
        else
        {
            Console.WriteLine ("D2:No");
            Console.WriteLine("D2:No!");
        }

        Console.WriteLine("Done");
    }

    void partE() {
        int numberE;
        numberE = 6;

        if (numberE <= 7 )
        {
            Console.WriteLine("E:Yes");
        }
        else
            Console.WriteLine("E:No");

        Console.WriteLine("Done");
    }

    // Now watch the Video on Recap on Combining Conditions and Boolean values, before you continue with Part F
 
    void partF() {
        int numberF1;
        int numberF2;
    
        numberF1 = 6;
        numberF2 = 7;

        if (numberF1 < 7 || numberF2 < 7)
            Console.WriteLine("F:Yes");
        else
        {
            Console.WriteLine("F:No");
        }
    
        Console.WriteLine("Done");
    }

    void partG() {
        int numberG1;
        int numberG2;
        numberG1 = 6;
        numberG2 = 7;

        if (numberG1 < 7 && numberG2 < 7) 
            Console.WriteLine("G: Yes");
        else
            Console.WriteLine("G: No");
    
        Console.WriteLine("Done");
    }
}