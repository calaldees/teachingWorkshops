// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-static

using System;
using static System.Console;
using static System.Math;
using static System.String;

using System;
class Example {
    static void Main(string[] args) {new Example();}
    Example() {
        WriteLine("You don't need Console.WriteLine each time");
        Format("-{0}-", 12);
        WriteLine(PI);
    }
}