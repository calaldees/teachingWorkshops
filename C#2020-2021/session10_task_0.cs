using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        // example1();
        example2();
        example3();
        example4();
        example5();
        exampleX();
    }

    void example1() {
        string[] employees = new string[4];
        int[] empHours = new int[4];

        for (int loopCounter = 0; loopCounter < 4; loopCounter++) {
            Console.WriteLine( "Please Enter Employee Name");
            employees[loopCounter] = Console.ReadLine();

            Console.WriteLine("Enter hours for {0}" ,employees[loopCounter]);
            empHours[loopCounter] = int.Parse(Console.ReadLine());
        }
    }

    void example2() {
        int[,] array2D = new int[,] { 
            { 1, 2 }, 
            { 3, 4 }, 
            { 5, 6 }, 
            { 7, 8 }
        };
        // This creates a 2D array with two columns and 4 rows:
        // Column 1 = 1,3,5,7
        // Column 2 = 2,4,6,8
    }


    int[,] initHoursWorked() {
        // rows are weeks
        // cols are employees
        // e.g. employee 2 worked 
        //   38 hours in week 0
        //   38 hours in week 1
        //   35 hours in week 2
        //   40 hours in week 3
        // New weeks can be added easily to the bottom
        return new int[,] {
            {15, 40, 38, 40, 60, 12},
            {15, 40, 38, 40, 45, 14},
            {20, 45, 35, 15, 55, 15},
            {18, 40, 40, 40, 20, 14},
        };
    }

    void example3() {
        int[,] hoursWorked = initHoursWorked();

        hoursWorked[3, 2] = 15;
        Console.WriteLine(hoursWorked[3, 1]);
    }

    void example4() {
        Console.WriteLine("example4 - iterating over one colum");
        int[,] hoursWorked = initHoursWorked();

        const int employeeId = 4;
        int employeeHourTotal = 0;
        for (int hourWeekLoop=0; hourWeekLoop < hoursWorked.GetLength(0) ; hourWeekLoop++) {
            employeeHourTotal += hoursWorked[hourWeekLoop, employeeId];
        }

        Console.WriteLine("hours Total Hours are: " + employeeHourTotal);
    }

    void example5() {
        Console.WriteLine("example5 - nested iteration over multiple dimensions");
        int[,] hoursWorked = initHoursWorked();

        for(int employeeId=0 ; employeeId < hoursWorked.GetLength(1); employeeId++) {
            int employeeHourTotal = 0;
            for (int hourWeekLoop=0; hourWeekLoop < hoursWorked.GetLength(0) ; hourWeekLoop++) {
                employeeHourTotal += hoursWorked[hourWeekLoop, employeeId];
            }
            Console.WriteLine("employeeId: "+ employeeId + " employeeHourTotal: "+employeeHourTotal);
        }

    }

    // C# multi dimensional arrays are regular in size

    // Jagged arrays 

    void exampleX() {
        Console.WriteLine("exampleX - jagged arrays");
        int[][] jagged = new int[][]{
            new int[]{1,2,3},
            new int[]{4,5,6,7,8},
            new int[]{9,10}
        };
        Console.WriteLine(jagged[0][0]);
        Console.WriteLine(jagged[1][4]);
        Console.WriteLine(jagged[2][1]);
    }


}
