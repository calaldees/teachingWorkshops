/*
Task 1 – Finding the Product of 6 numbers
The user is to enter six integers. Each number is to be stored in an array element. 
The program then goes through the array replacing the numbers stored with the partial product of the numbers (i.e. the product of the numbers so far.)
These are then displayed to the screen in order.
E.g.
Initially
Index	0	1	2	3	4	5
Number	0	0	0	0	0	0

After User entry
Index	0	1	2	3	4	5
Number	5	4	6	2	1	8

After product calculation
Index	0	1	2	3	4	5
Number	5	20	120	240	240	1,920

To do this last part, start your iteration from 1, rather than 0 and think about how you would use the loop counter variable to refer to the index of the PREVIOUS item. 
 
*/
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
        int[] numbers = new int[6];
        //for (int i=0 ; i<numbers.Length ; i++) {
        //    numbers[i] = int.Parse(Console.ReadLine());
        //}
        numbers = new int[]{5,4,6,2,1,8};  // comment this out for user input
        
        for (int i=1 ; i<numbers.Length ; i++) {
            numbers[i] = numbers[i-1] * numbers[i];
        }
        Console.WriteLine(String.Join(",", numbers));
    }
}
