/*
Compile and use as library
```bash
    mcs /t:library /out:example_input.dll example_input.cs
    mcs /t:exe /reference:example_input.dll /out:test.exe session7_workshop2_task_3.cs
    mono test.exe
```
```csharp
using static InputHelper;
    ...
    int v = askInt();
```

More reading
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-options/reference-compiler-option
    https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive
    https://stackoverflow.com/questions/14728422/c-sharp-importing-class-into-another-class-doesnt-work
    https://stackoverflow.com/questions/8264783/how-to-reference-these-packages-with-mono-in-order-to-compile
*/

using System;
//namespace InputHelper {
public class InputHelper {
    static void Main(string[] args) {
        // example use
        int i = askInt();
        string m = askString("enter a 3 letter month: ", new string[]{"jan", "feb"});
    }

    public static int askInt() {return askInt("input an integer: ");}
    public static int askInt(string msg) {return askInt(msg, 0, int.MaxValue);}
    public static int askInt(string msg, int min, int max) {
        while (true) {
            Console.Write(msg);
            int v = int.MinValue;
            try {
                v = int.Parse(Console.ReadLine());
            } catch (Exception) {
                continue;
            }
            if (v < min || v > max) {
                string error_msg = String.Format("Outside range {0} {1}", min, max);
                Console.WriteLine(error_msg);
                continue;
                //throw new System.IO.InvalidDataException(error_msg);
            }
            return v;
        }
    }

    public static string askString(string msg, string[] oneOf) {
        while (true) {
            Console.Write(msg);
            string input = Console.ReadLine();
            if (Array.IndexOf(oneOf, input) < 0) {
                Console.WriteLine(String.Join(",", oneOf));
                continue;
            }
            return input;
        }
    }

}
//}