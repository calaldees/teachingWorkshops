using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        /*
        Write a program that requests the user type in a string of characters. It then produces the following outputs
        •	The length of the string
        •	The first and last letters of the string
        •	Whether it contains the letter “A”
        •	If the string is more than 2 characters long, the string with the word “Jelly” inserted in the middle of it
        */

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("length: " + input.Length);
        Console.WriteLine("first letter: " + input[0]);
        Console.WriteLine("last letter: " + input[input.Length-1]);

        string c = "A";
        if (input.IndexOf(c) >= 0) {
            Console.WriteLine("It does contain " + c);
        } else {
            Console.WriteLine("It does not contain " + c);
        }

        if (input.Length > 2) {
            input = input.Insert(input.Length/2, "Jelly");
        }
        Console.WriteLine("input with Jelly! -> "+input);
    }
}