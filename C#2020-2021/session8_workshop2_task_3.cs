/*
Task 3 (if you have time) Word Guesser

This program should be implemented using a ‘for’ loop. This game should give a user 4 guesses what word the computer ‘is thinking of’ (It’s not really thinking – just using random number to decide which word to choose).
The following code should be copied into the start of your program.

   string[] wordList = {
        "Apple",
        "Banana",
        "Clementine",
        "Fig",
        "Grape",
        "Kiwi",
        "Lime",
        "Melon",
        "Nectarine",
        "Orange",
        "Pear",
        "Quince",
        "Strawberry",
        "Watermelon"
    };

    Random randomGenerator = new Random();
    int fruitIndex = 0;
    string fruitChosen = null;

    fruitIndex = randomGenerator.Next(0, 14);
    fruitChosen = wordList[fruitIndex];

    Console.WriteLine("The computer has chosen a fruit... You must guess what it is");


If the user guesses correctly, then return the phrase ‘sweet fruit’, otherwise return the phrase ‘Rotten guess’ for each guess. If they never guess after the 4 chances, then display the correct word.
*/
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        string[] wordList = {
            "Apple",
            "Banana",
            "Clementine",
            "Fig",
            "Grape",
            "Kiwi",
            "Lime",
            "Melon",
            "Nectarine",
            "Orange",
            "Pear",
            "Quince",
            "Strawberry",
            "Watermelon"
        };

        Random randomGenerator = new Random();
        int fruitIndex = 0;
        string fruitChosen = null;

        fruitIndex = randomGenerator.Next(0, wordList.Length);
        fruitChosen = wordList[fruitIndex];

        Console.WriteLine("The computer has chosen a fruit... You must guess what it is");

        // ----

        const int guesses = 4;
        for (int guessNum=1 ; guessNum <= guesses; guessNum++) {
            string input = Console.ReadLine();
            if (fruitChosen.ToLower() == input.ToLower()) {
                Console.WriteLine("You found it!");
                break;
            }
            else {
                Console.WriteLine("No it is not "+input+" you have "+(guesses-guessNum)+" guess's left");
            }
        }
        Console.WriteLine("The fruit was "+fruitChosen);
    }
}