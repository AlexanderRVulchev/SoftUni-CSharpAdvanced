using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        // Fields
        private List<Car> cars;
        private int capacity;

        // Properties
        public List<Car> Cars { get { return cars; } set { cars = value; } }
        public int Count { get { return cars.Count; } }

        // Constructors
        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        // Methods
        public string AddCar(Car car)
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
                return "Car with that registration number, already exists!";
            else if (this.capacity <= this.Cars.Count)
                return "Parking is full!";
            else
            {
                this.cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.cars.Any(c => c.RegistrationNumber == registrationNumber))
                return $"Car with that registration number, doesn't exist!";
            else
            {
                this.cars
                    .Remove(cars
                    .Find(c => c.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }
        }

        public Car GetCar(string registrationNumber)
        => this.cars.Find(c => c.RegistrationNumber == registrationNumber);

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string number in RegistrationNumbers)
            {
                RemoveCar(number);
            }
        }
    }
}
