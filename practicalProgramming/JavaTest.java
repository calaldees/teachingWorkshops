import java.util.Scanner;

public class JavaTest {

    Scanner console = new Scanner(System.in);

    // void life_story(String name) {
    //    System.out.println("My name is");
    //    System.out.println(name);
    //    System.out.println("I live in the sea");
    // }

    Integer add(Integer a, Integer b) {
        return a + b;
    }


    public JavaTest() {
        System.out.println("Input1");
        String input1 = console.nextLine();
        Integer input1_integer = Integer.parseInt(input1);

        System.out.println("Input2");
        String input2 = console.nextLine();
        Integer input2_integer = Integer.parseInt(input2);

        if (input_ == "" ){
        }

        System.out.println(input1_integer + input2_integer);
    }

    public static void main(String[] args) {
        new JavaTest();
    }
}