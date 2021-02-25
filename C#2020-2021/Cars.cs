using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace VehicleEngineLibrary
{
    class Car {

        public static void Main(string[] args) {
            Console.WriteLine("Hello");

            /*
            List<Car> cars = new List<Car>(new Car[]{
                new Car("Honda", "Civic", 55),
                new Car("Ford", "Ka", 45),
                new Car("Audi", "A4", 62)
            });
            */

            //Car[] cars = new Car[]{
            List<Car> cars = new List<Car>();
            cars.Add( new Car("Honda", "Civic", 55) );
            cars.Add( new Car("Ford", "Ka", 45) );
            cars.Add( new Car("Audi", "A4", 62) );
            //};
            
            car.AddFuel(double.Parse(Console.ReadLine()))??
            //   if ( ??? > MaxFuel){


            int i = 1;
            foreach (Car car in cars) {
                Console.WriteLine($"{i}.) "+car);
                i++;
            }
            //
                //Console.WriteLine($"My car is {car.GetModelName()} its a ");
                //Console.WriteLine(car);
                //i++;

            Console.WriteLine("Enter Car Num: ");
            int car_index = int.Parse(Console.ReadLine());
            /**
            if (car_index == 0) {
                cars.Add(CreateCarWithUserInput());
                car_index = cars.Count;
            }
            **/
            Car _car = cars[car_index-1];

            Console.WriteLine(_car);

            Console.WriteLine("Add Fuel: ");
            _car.AddFuel(double.Parse(Console.ReadLine()));

            Console.WriteLine(_car);

            Console.WriteLine("Remove Fuel: ");
            try {
                _car.RemoveFuel(double.Parse(Console.ReadLine()));
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(_car);
        }

        public static Car CreateCarWithUserInput() {
            Console.WriteLine("Enter a new Car");
            return new Car(
                askString("Make: "),
                askString("Model: "),
                askInt("Fuel: ")
            );
        }
// -----------------------------------------------------------------------------

        #region attributes

        private string model;
        private string make;        
        private double fuel_liters;
        public double fuel {
            get {return fuel_liters;}
            set {
                if (value < 0) {
                    throw new Exception("Fuel cannot be negative");
                }
                if (value > maxFuel_liters) {
                    throw new Exception("Attempted to set fuel to greater than capacity");
                }
                fuel_liters = value;
            }
        }
        private double maxFuel_liters;

        #endregion

        #region Constructors
        /// <summary>
        /// Empty Constructor
        /// </summary>
        public Car()
        {
            model = "N/A";
            make = "N/A";
            maxFuel_liters = 0;
            fuel_liters = 0;
        }

        /// <summary>
        /// Constructor by setting car make, model and maximum fuel in liters
        /// </summary>
        /// <param name="CarMake">Brand/Make of car</param>
        /// <param name="CarModel">Type of car</param>
        /// <param name="MaximumFuel">Maximum capacity of fuel tank in liters</param>
        public Car(string CarMake, string CarModel, double MaximumFuel)
        {
            model = CarModel;
            make = CarMake;
            fuel_liters = 0;
            maxFuel_liters = MaximumFuel;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns the model name of the car
        /// </summary>
        /// <returns>Model name</returns>
        public string GetModelName()
        {
            return model;
        }

        /// <summary>
        /// Returns the make of the car
        /// </summary>
        /// <returns>Make</returns>
        public string GetMake()
        {
            return make;
        }

        public double GetMaxFuel() {
            return maxFuel_liters;
        }


        /// <summary>
        /// Returns the current fuel on the car
        /// </summary>
        /// <returns>Current fuel in liters</returns>
        //public double GetCurrentFuel()
        //{
        //    return fuel_liters;
        //}

        /// <summary>
        /// Adds fuel in the car
        /// </summary>
        /// <param name="amount">the amount of fuel to add in liters</param>
        public void AddFuel(double amount)
        {
            fuel += amount;
        }

        public void RemoveFuel(double amount) {
            fuel -= amount;
        }

        public override string ToString()
        {
            return $"Car(make={GetMake()}, model={GetModelName()} fuel={fuel}/{GetMaxFuel()})";
        }

        #endregion


// -----------------------------------------------------------------------------
        public static string askString(){
            return askString("enter a string: ");
        }
        public static string askString(string msg) {
            Console.Write(msg);
            return Console.ReadLine();
        }
        public static string askString(string msg, string[] oneOf) {
            while (true) {
                Console.Write(msg);
                string input = Console.ReadLine();
                if (Array.IndexOf(oneOf, input) < 0) {
                    Console.WriteLine(String.Join(",", oneOf));
                    continue;
                }
                return input;
            }
        }

        public static int askInt() {return askInt("input an integer: ");}
        public static int askInt(string msg) {return askInt(msg, 0, int.MaxValue);}
        public static int askInt(string msg, int min, int max) {
            while (true) {
                Console.Write(msg);
                int v = int.MinValue;
                try {
                    v = int.Parse(Console.ReadLine());
                } catch (Exception) {
                    continue;
                }
                if (v < min || v > max) {
                    string error_msg = String.Format("Outside range {0} {1}", min, max);
                    Console.WriteLine(error_msg);
                    continue;
                    //throw new System.IO.InvalidDataException(error_msg);
                }
                return v;
            }
        }


    }

}
