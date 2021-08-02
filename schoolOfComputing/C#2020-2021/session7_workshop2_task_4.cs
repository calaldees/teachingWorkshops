/*
Task 4 – Counting Word Occurrences in a string (Challenge!)
Ask the user to enter a sentence and then a word. The program is to return the number of times the word is present in the sentence as a complete word. Ignore case. The sentence will end with a full stop, and this should not be part of the word.
*/
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        Console.Write("Enter a sentence");
        string data = "The quick brown fox jumped over the lazy dog. The dog was confused.";
        //data = Console.ReadLine();
        Console.WriteLine(data);

        Console.Write("Enter a whole word to search for: ");
        string search = Console.ReadLine();

        int found = 0;
        string[] words = data.Split(" ");
        foreach (string word in words) {
            if (word.ToLower() == search.ToLower()) {found++;}
        }
        Console.WriteLine("Found "+search+" "+found+" times");
        // Question: typing dog only return found 1 - can you spot why?
    }
}