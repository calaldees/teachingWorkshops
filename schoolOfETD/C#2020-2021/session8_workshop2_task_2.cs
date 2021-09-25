/*
Task 2 – Storing strings in an array
Write a program that asks a user for 5 strings. Store these in an array of strings. Then ask the user for a word. Return a count of how many of the 5 strings contain that word. You can use IndexOf to determine whether or not a string is found in another one – it returns -1 if it is not present, and a different value if it is present.
E.g.
User enters
1.	‘Apples are red’
2.	‘The sea is green’
3.	‘The sky is blue’
4.	‘Cherries are red’
5.	‘That mouse is white’
And the word to find ‘is’
The system should return 3.
 
*/
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        string[] words = new string[]{
            "Apples are red",
            "The sea is green",
            "The sky is blue",
            "Cherries are red",
            "That mouse is white",
        };
        Console.WriteLine("Enter 5 words");
        for (int i=0 ; i<words.Length ; i++) {
            //words[i] = Console.ReadLine();
        }
        Console.WriteLine("Words: "+String.Join(",", words));

        Console.Write("Enter text to search for: ");
        string search = Console.ReadLine();

        int count = 0;
        for (int i=0 ; i<words.Length ; i++) {
            if (words[i].IndexOf(search) >= 0) {
                count++;
            }
        }
        Console.WriteLine("Found "+count+" occurrences of "+search);
    }
}