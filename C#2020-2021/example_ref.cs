using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        /* ByRef ByValue Examples*/
        example_ref();
        example_out();
        example_in();
    }

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ref
    void example_ref() {
        int number = 1;
        _byRefExampleMethod(ref number);
        Console.WriteLine(number);
        // Output: 45
    }
    void _byRefExampleMethod(ref int refArgument)
    {
        refArgument = refArgument + 44;
    }

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/out-parameter-modifier
    // `out` - It is like the `ref` keyword, except that `ref` requires that the variable be initialized before it is passed
    void example_out() {
        int initializeInMethod = 55;
        _OutArgExample(out initializeInMethod);
        Console.WriteLine(initializeInMethod);     // value is now 44
    }
    void _OutArgExample(out int number)
    {
        number = 44;
    }

    // https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/in-parameter-modifier
    void example_in() {
        int readonlyArgument = 44;
        _InArgExample(readonlyArgument);
        Console.WriteLine(readonlyArgument);     // value is still 44
    }
    //void _InArgExample(in int number)  // error CS1644: Feature `readonly references' cannot be used because it is not part of the C# 7.0 language specification
    void _InArgExample(int number)
    {
        // Uncomment the following line to see error CS8331
        //number = 19;
    }
    class InOverloads
    {
        //public void SampleMethod(in int i) { }
        public void SampleMethod(int i) { }
    }
}