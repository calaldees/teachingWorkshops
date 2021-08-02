using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        partA();
        partB();
        partC();
        partD();
        partE();
        partF();//partG();
        partH();
    }

    void partA() {
        string a;
        a = "Hello";
        Console.WriteLine("a");
    }

    void partB() {
        string b;
        b = "Hello";
        Console.WriteLine(b);
    }

    void partC() {
        string c;
        c = "Hello";
        Console.WriteLine(c + "World");
    }

    void partD() {
        string d;
        string e;
        d = "Hello";
        e = "World";
        Console.WriteLine(d + " " + e);
    }

    void partE() {
        string f;
        f = "Hello World";
        Console.WriteLine(f.Substring(6));
        Console.WriteLine(f.Substring(0, 5));
    }

    void partF() {
        string g;
        string h;
        g = "Hellrld";
    //}
    //void partG() {
        h = g.Insert(4, "o Wo");
        Console.WriteLine(g);
        Console.WriteLine(h);
    }

    void partH() {
        string i = "Hello World";
        Console.WriteLine(i.IndexOf("l"));
        Console.WriteLine(i.IndexOf("l", 4));
    }
}