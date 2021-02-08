using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace VehicleEngineLibrary
{
    class Cars {

        public static void Main(string[] args) {
            new Cars();
            Console.WriteLine("Hello");

            Cars[] cars = new Cars[]{
                new Cars("Honda", "Civic", 55),
                new Cars("Ford", "Ka", 45),
                new Cars("Audi", "A4", 62),
            };

            int i = 0 ;
            foreach (Cars car in cars) {
                Console.WriteLine($"{i}.) "+car);
                i++;
            }

            Console.WriteLine("Enter Car Num: ");
            Cars _car = cars[int.Parse(Console.ReadLine())];

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
        public Cars()
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
        public Cars(string CarMake, string CarModel, double MaximumFuel)
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
            return $"Cars(make={GetMake()}, model={GetModelName()} fuel={fuel}/{GetMaxFuel()})";
        }

        #endregion
    }
}
