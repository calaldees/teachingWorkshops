using System;
using System.Collections.Generic;

// https://www.tutorialsteacher.com/csharp/csharp-delegates

public class Task {
    public static void Main(string[] args) {new Task();}

    public delegate void SortDelegate(int[] data); // declare a delegate

    Task() {
        Console.WriteLine("Hello");
        IDictionary<string, SortDelegate> SortAlgorithms = new Dictionary<string, SortDelegate>(){
                {"Q", QuickSort},
                {"M", MergeSort},
        };

        int[] data = new int[]{1,2,3,4};
        SortAlgorithms["M"](data);
    }

    public static void QuickSort(int[] data) {
        Console.WriteLine($"QuickSort: {String.Join(",", data)}");
    }
    public static void MergeSort(int[] data) {
        Console.WriteLine($"MergeSort: {String.Join(",", data)}");
    }
}
