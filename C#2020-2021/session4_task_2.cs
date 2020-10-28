using System;

public class Task
{
    public static void Main(string[] args) {new Task();}

    Task() {
        int precipitation;
        decimal temperature;
        int windspeed;

        Console.Write("Please enter the expected precipitation today (mm): ");
        precipitation = int.Parse(Console.ReadLine());

        Console.Write("Please enter the expected temperature today(DEG C): ");
        temperature  = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter the expected windspeed today (MPH): ");
        windspeed = int.Parse(Console.ReadLine());

        evalutateConditions(precipitation, temperature, windspeed);
    }

    void evalutateConditions(int precipitation, decimal temperature, int windspeed) {
        // Part A
        // Write an if statement that says “Careful, it may be icey” if the temperature is below freezing
        if (temperature < 0) {
            Console.WriteLine("Careful, it may be icey");
        }

        // Part B
        // Write a conditional statement that says, “You’ll get wet” if the precipitation is above 10.
        if (precipitation > 10) {
            Console.WriteLine("You’ll get wet");
        }


        // Part C
        // Write an if statement that says, “It’s a hurricane” if the windspeed is above 100, otherwise say “It’s not THAT windy”
        if (windspeed > 100) {
            Console.WriteLine("It’s a hurricane");
        }
        else {
            Console.WriteLine("It’s not THAT windy");
        }

        // Part D
        // If the precipitation is above 5 AND the windspeed is below 10, “You could use an umbrella”
        if (precipitation > 5 && windspeed < 10) {
            Console.WriteLine("You could use an umbrella");
        }

        // Part E
        // If the precipitation  is above 40 AND the temperature is below freezing “Bring a sledge”, otherwise “leave the sledge in the shed”
        if (precipitation > 40 && temperature < 0) {
            Console.WriteLine("Bring a sledge");
        }
        else {
            Console.WriteLine("leave the sledge in the shed");
        }

        // Part F
        // If the temperature is below -10 OR the temperature is above 40 , “Stay inside!”, otherwise “You can go out”
        if (temperature < -10 || temperature > 40) {
            Console.WriteLine("Stay inside!");
        }
        else {
            Console.WriteLine("You can go out");
        }

        // Part G
        // If the precipitation is above 0 and the wind speed is above 5, “Wear a coat”, otherwise if the precipitation is above 0 and the windspeed is less than or equal to 5, “Take a brolly”
        if (precipitation > 0 && windspeed > 5) {
            Console.WriteLine("Wear a coat");
        }
        else if (precipitation > 0 && windspeed <= 5) {
            Console.WriteLine("Take a brolly");
        }

        // Part H
        // If the  temperature is above 20 and precipitation is 0 OR temperature less than 5, then “Time for a drink”
        if (temperature > 20 && precipitation == 0 || temperature < 5) {
            Console.WriteLine("Time for a drink");
        }

    }
}








