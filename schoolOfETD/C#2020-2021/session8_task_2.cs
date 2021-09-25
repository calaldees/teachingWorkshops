/*
Task 2 – 1D Arrays
Part A- Understanding 1D Arrays
Copy and paste the following code into a new project in Visual Studio
           int[] classAges = new int[7];
            classAges[0] = 30;
            classAges[1] = 25;
            classAges[2] = 45;
            classAges[3] = 22;
            classAges[4] = 19;
            classAges[5] = 19;
            classAges[6] = 21;

1.	Write some C# Code that will display the age of the person held in index location 4
2.	Place the following code under the variable declaration statement at the top of the code
int ageLoop;

3.	Copy and paste the following code into Visual Studio
    	     for (ageLoop = 0; ageLoop <= 6; ageLoop++)
            {
                Console.Write("The person at index ");
                Console.Write(ageLoop.ToString());
                Console.Write(" is " + classAges[ageLoop].ToString());
                Console.WriteLine(" years old");

            }
Run the program and see how it works
4.	Now insert a simple If statement in to the loop so that the person and their age are only displayed if they are 30 years old or older. 
Your if statement will need to check if the person’s age stored in the classAges array at location is >= 30.
Run this code to make sure it works
5.	Add a declaration of a variable called olderCount of type integer in a suitable location and initialise this to 0
6.	Write code so that this variable is incremented by 1 each time an older person (30 or older) is found in the ‘for’ loop.
7.	Add code so that the number of older people is displayed after the for loop, i.e. when the loop ‘terminates’
8.	Add a declaration of a variable called olderAgeSum of type integer in a suitable location. Now add code to initialise this variable to 0 at a suitable location.
9.	In each iteration of the loop add the persons age to the current value of olderAgeSum if they are 30 or older
10.	After the loop has terminated, display the sum stored in olderAgeSum
11.	Now calculate the mean average age of the older people on the basis that 
meanAge = olderAgeSum / olderCount
and display this suitably.
Part B – Extending the code for user input
The code above should now produce the sum and mean average of all the older people in the array (i.e. it ignores the youngsters!)
Now write code so that the ages of 10 people are entered by the user into the system, which stores all these 10 ages in the classAges array (you will need to modify the declaration of the classAges array)
Also ask the user for a minimum age and store this in a suitably named variable.
Then use the same code to calculate the mean average of everyone over the minimum age entered by the user.
*/