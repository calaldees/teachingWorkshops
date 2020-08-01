
Look at each others solutions
Size of bmp

same as session 1
in static language
java?


Visual Basic Community: ConsoleApplication?
Tests for size calculator

spec bingo

---

Following on from today's session
Here is a stub Java file
See how I've created my own `input()` and `print()` functions to make the code easier to read.
Whenever things start to look complex - move that complexity into a function.
See if you can implement `+` `-` `*` and for the overachievers `/` (this will be very interesting)

```java
import java.util.Scanner;

class Session2 {

    Scanner console = new Scanner(System.in);

    void print(Object o) {System.out.println(o);}
    String input() {return console.nextLine();}

    Integer add(Integer a, Integer b) {
        return a + b;
    }

    Session2() {
        print("input_a: ");
        String input_a = input();
        print("input_b: ");
        String input_b = input();
        print("what operation do you want to perform (+ or *): ");
        String operation = input();

        Integer a = Integer.parseInt(input_a);
        Integer b = Integer.parseInt(input_b);
        Integer answer = 0;
        if (operation.equals("+")) {
            answer = -1 //???
        }

        print(answer);
    }

    public static void main(String[] args) {new Session2();}
}
```