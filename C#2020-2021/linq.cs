using System;
using System.Collections.Generic;
//using System.Linq;  // Adds `.Concat` to list object - I'm not confortable with this modification of existing objects

// https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/
// Live SQL in IDE?!?! WTF!?

public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        // From https://dotnettutorials.net/lesson/linq-concat-operator/
        List<int> sequence1 = new List<int> { 1, 2, 3, 4 };
        List<int> sequence2 = new List<int> { 2, 4, 6, 8 };

        foreach (var item in sequence1) {Console.WriteLine(item);}

        //var sequence3 = sequence1.Concat(sequence2);
        //foreach (var item in sequence3) {Console.WriteLine(item);}
    }
}