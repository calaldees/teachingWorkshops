package practicalProgramming;

import java.util.Scanner;

class Session2 {

    Scanner console = new Scanner(System.in);

    void print(Object o) {System.out.println(o);}
    String input() {return console.nextLine();}

    void my_life_story(String name) {
        print("my name is");
        print(name);
        print("I was born on the moon");
        print("I like eating pizza");
        print("by the age of 12 I was 3 meaters tall");
        print("One day I will visit the sea");
        print("so thats my story - from");
        print(name);
    }

    Integer add(Integer a, Integer b) {
        return a + b;
    }

    Session2() {
        //my_life_story("Bobbin");
        //print("Hello World");
        //my_life_story("Moomin");

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
            answer = add(a, b);
        }
        else if (operation.equals("*")) {
            print("not implemented");
        }
        else {
            print("operation " + operation + " is not supported");
            System.exit(1);
        }
        print(answer);
    }

    public static void main(String[] args) {new Session2();}
}