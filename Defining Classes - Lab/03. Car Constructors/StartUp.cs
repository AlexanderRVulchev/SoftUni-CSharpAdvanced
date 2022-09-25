//Using the class from the previous problem create one parameterless constructor with default values:
//•	Make – VW
//•	Model – Golf
//•	Year – 2025
//•	FuelQuantity – 200
//•	FuelConsumption – 10
//Create a second constructor accepting make, model, and year upon initialization
//and call the base constructor with its default values for fuelQuantity and fuelConsumption. 
//Create a third constructor accepting make, model, year, fuelQuantity, and fuelConsumption
//upon initialization and reuse the second constructor to set the make, model, and year values. 
//Go to StartUp.cs file and make 3 different instances of the Class Car, using the different overloads of the constructor.


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

            // Properties
            public string Make { get { return make; } set { make = value; } }
            public string Model { get { return model; } set { model = value; } }
            public int Year { get { return year; } set { year = value; } }
            public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
            public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }

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