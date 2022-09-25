//Using the Car class, you already created, define another class Engine.
//The class should have private fields for:
//•	horsePower: int
//•	cubicCapacity: double
//The class should also have properties for:
//•	HorsePower: int
//•	CubicCapacity: double
//The class should also have a constructor, which accepts horsepower and cubicCapacity upon initialization 
//Now create a class Tire.
//The class should have private fields for:
//•	year: int
//•	pressure: double
//The class should also have properties for:
//•	Year: int
//•	Pressure: double
//The class should also have a constructor, which accepts year and pressure upon initialization 
//Finally, go to the Car class and create private fields and public properties for Engine and Tire[].
//Create another constructor, which accepts
//make, model, year, fuelQuantity, fuelConsumption, Engine, and Tire[] upon initialization:


using System;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        class Car
        {
            // Fields
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            private Engine engine;
            private Tire[] tires;

            // Properties
            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year { get { return year; } set { year = value; } }
            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
            public Engine Engine { get { return engine; } set { engine = value; } }
            public Tire[] Tires { get { return tires; } set { tires = value; } }

            // Constructors
            public Car()
            {
                this.Make = "VW";
                this.Model = "Golf";
                this.Year = 2025;
                this.FuelQuantity = 200;
                this.FuelConsumption = 10;
            }

            public Car(string make, string model, int year) : this()
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
                : this(make, model, year)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumption = fuelConsumption;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
                : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Tires = tires;
                this.Engine = engine;
            }

            // Methods
            public void Drive(double distance)
            {
                double fuelToSpend = distance * this.fuelConsumption;
                if (this.FuelConsumption - fuelToSpend >= 0)
                    this.FuelQuantity -= fuelToSpend;
                else
                    Console.WriteLine("Not enough fuel to perform this trip!");
            }

            public string WhoAmI()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Make: {this.Make}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Year: {this.Year}");
                sb.AppendLine($"Fuel: {this.FuelQuantity:f2}");
                return sb.ToString();
            }
        }

        public static void Main()
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuantity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());

            Car firstCar = new Car();
            Car secondCar = new Car(make, model, year);
            Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);
        }
    }
}