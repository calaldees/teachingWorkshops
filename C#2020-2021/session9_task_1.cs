/*Workshop 9b – Using multiple constructs 
Dave Bennett
Task 1 – For Loops and revisiting calculations
This exercise is about being able to modify existing code and selecting the most appropriate programming construct to complete a task. 
Programmers in industry often have to change existing code and business scenarios change or the code is required to be more sophisticated and do more.
However, there will be different ways of doing the task and a programmer has to determine the most appropriate way of implementing this. 
Finally, they have to check that their code is working properly before they ask others to also check they are happy with it in some sort of code review.

1)	Download and extract (unzip) the project PayCalc_StrIter from Blackboard.
a.	Read through the code and re-familiarise yourself with it. This version uses job role as an input rather than pay rate and has overtime payments.
2)	Convert all variables and code based around using integers to calculate values in pennies to use decimal type variables and values based in £.
3)	It is, however, based around weekly pay rather than monthly pay.
4)	In the marked section add code to 
a.	determine the month of the year from the user using string input and then
b.	use the following table to determine the number of weeks in that month – storing the result in a integer variable weeksInMonth that you declare.
Month	Weeks in Month
Jan	5
Feb	4
Mar	5
Apr	4
May	4
Jun	4
Jul	4
Aug	4
Sep	4
Oct	5
Nov	4
Dec	5
Total	52


 

5)	In the marked section add code, using a for loop, to iterate through each week of that month, adding the weekly hours worked to the totalHours.
6)	Modify the pay calculation for each job as follows:
a.	Cleaner – standard pay rate throughout
b.	Grad Clerk – normal pay up to 35 hours per week MEAN AVERAGE (total hours in the month divided by weeks in month) and overtime above this
c.	Senior Clerk – normal pay up to 40 hours per week MEAN AVERAGE and double rate up to 48 hours per week, and triple time above this. (This will involve more modifications to the code.

7)	Modify the tax calculation so that it operates on the tax break from the low rate of 10% to the higher rate of 25% at £12,000 per annum of 52 weeks rather than £200 per week. This means you will have to again look at the number of weeks in the month and the pay and determine what the tax allowance would be for that month based on the £10,000 figure. (this is slightly higher than it is currently).
8)	Test your program now works by creating a set of 5 different test cases that you have calculated the correct answer using Excel, or a calculator and paper.
9)	For one of these create a trace table of the program dry run.
10)	Finally, show your code to another person in the class who has also done tasks 1-9 and get them to compare it with theirs. Where is it different? Why have you implemented the code in the way you have and which do you feel is better? You do not need to change your code, but reflect if there are any lessons to be learned. Make brief notes on this. Once you have done this show your code to your tutor.
*/
using System;
public class Task {
    public static void Main(string[] args) {new Task();}
    Task() {
    }
}