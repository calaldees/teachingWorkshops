using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        //example1();
        //example2();
        //example3();
        example4();
    }

    void example1() {
        int choice;
        Console.Write("Please enter job ID (1-8): ");
        choice = int.Parse(Console.ReadLine());

        if (choice == 1 || choice == 2)
            Console.WriteLine("Clerk");
        else if (choice == 3)
            Console.WriteLine("Cleaner");
        else if (choice >= 4 && choice <=6 )
            Console.WriteLine("Accountant");
        else if (choice > 6)
            Console.WriteLine("Manager");
    }

    void example2() {
        int choice;
        Console.Write("Please enter job ID (1-8): ");
        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            case 2:
                Console.WriteLine("Clerk");
                break;
            case 3:
                Console.WriteLine("Cleaner");
                break;
            case 4:
            case 5:
            case 6:
                Console.WriteLine("Accountant");
                break;
            case 7:
            case 8: 
                Console.WriteLine("Manager");
                break;
            default:
                Console.WriteLine("Unknown Job");
                break;
        }
    }

    void StartService(){}
    void StopService(){}
    void example3() {
        string commandName = "start"; 
        switch (commandName)
        { 
            case "start":
                Console.WriteLine("Starting service...");
                StartService(); 
                break;
            case "stop": 
                Console.WriteLine("Stopping service...");
                StopService();
                break;
            default:
                Console.WriteLine(String.Format("Unknown command: {0}", commandName)); 
                break;
        }
    }

    void example4() {
        int choice;
        Console.Write("Please enter job ID (1-8): ");
        choice = int.Parse(Console.ReadLine());

        /*
        // `when` clause not compatable with - C# 7 (VS2016 and earlier)
        switch (choice)
        {
            case int i when (i ==1 || i == 2 ):
                Console.WriteLine("Clerk");
                break;
            case 3:
                Console.WriteLine("Cleaner");
                break;
            case int i when i <=6:
                Console.WriteLine("Accountant");
                break;
            case 7: case 8: 
                Console.WriteLine("Manager");
                break;
            default:
                Console.WriteLine("Unknown Job");
                break;
        }
        */

    }
}