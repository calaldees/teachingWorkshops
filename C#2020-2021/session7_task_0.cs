using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        example1();
        example2();
        example3();
        example4();
        example5();
        example6();
        example7();
        example8();
        example9();
        //example10();
        example11();
    }

    /* Declaration, Initialisation, Scope */
    void example1() {

        int var1 = 20;  // Declaration & initialisation - Scope of var1

        int var2;  // Declaration
        var2 = 20;  // Initialisation

        string var3;  // Declaration - Scope of var1
        var3 = "hello";  // Initialisation
        // Strings are "A one-dimensional array of characters"
    }

    /* Initialisation from value, variable or function */
    /* Array indexing */
    void example2() {
        string myName;
        myName = "Joseph Cook";  // From value
        /*
            Joseph Cook
            0123456789
        */
        Console.Write(myName[0]);
        Console.Write(myName[7]);
        Console.WriteLine();


        string myDadsName = myName;  // From another variable of string type
        string myNumber = (5).ToString(); //From a function applied to another value
    }


    /* Properties of String */
    void example3() {
        string myName = "Lord Example";

        int len;
        len = myName.Length;
        Console.WriteLine(len.ToString());
    }

    /* Accessors */
    void example4() {
        // Substring is an accessor method that returns part of the String
        //string <string>.Substring(<start>, <length>)
        string myName = "Joseph Cook";
        Console.WriteLine(myName.Substring (0,3));

        // IndexOf method finds the zero-indexed position of a character or sequence of characters in a string
        // int <string>.IndexOf(<string>)
        Console.WriteLine(myName.IndexOf("o")); 
        //1,8,9 (zero-based indexes of 'o' characters)
        // ? only displays first occurrence
    }

    void example5() {
        // ascii table
        // unicode
        // 0 -> 127 == ascii
        // 128 -> 255 == special characters
        // 256 -> 65535 == symbols

    }

    /* Value and Reference types */
    void example6() {
        // Value
        int a;
        bool b;
        float c;

        // Reference
        string d;
    }

    /* Mutable & Immutable */
    void example7() {
        // String are immutable
        string a = "Hello";
        a += "!";  // this generate a new string
    }

    /* Mutators? not really - a new object */
    void example8() {
        string myName = "Joe";
        myName = myName.ToUpper();
        Console.WriteLine(myName);
        myName = myName.ToLower();
        Console.WriteLine(myName);
    }

    /* Mutator - insert */
    void example9() {
        string myName = "Joseph Cook";
        Console.WriteLine(myName);  //>>> Joseph Cook
        myName = myName.Insert(7, "M. ");
        Console.WriteLine(myName);  //>>> Joseph M. Cook
        Console.WriteLine(myName.ToUpper()); //>>> JOSEPH M. COOK
    }


    /* TryParse */
    void example10() {
        string userInput;
        int payRate;
        bool convertOK;

        Console.Write("Please enter pay rate: ");
        userInput = Console.ReadLine();  // if variable can be parsed as number, assign to payRate
        convertOK = int.TryParse(userInput, out payRate);

        if (! convertOK)
        {
            Console.WriteLine(userInput + " - is not digits");  // if variable cannot be parsed as number, display error message
            Console.ReadKey();
            System.Environment.Exit(1);
        }
    }

    /* TryParse in loop */
    void example11() {
        int choice;
        Console.WriteLine("Please enter a number 1-3");
        while (!(int.TryParse(Console.ReadLine(), out choice)) || (choice < 1 || choice > 3))
        {
            Console.WriteLine("Error: Please enter a number 1-3");
        }
        Console.WriteLine(choice);
    }

}