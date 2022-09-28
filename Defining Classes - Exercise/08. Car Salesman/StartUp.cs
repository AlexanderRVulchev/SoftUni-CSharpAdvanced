//Define two classes Car and Engine. 
//Start by defining a class Car that holds information about:
//•	Model: a string property.
//•	Engine: a property holding the engine object.
//•	Weight: an int property, it is optional.
//•	Color: a string property, it is optional.
//Next, the Engine class has the following properties:
//•	Model: a string property.
//•	Power: an int property.
//•	Displacement: an int property, it is optional.
//•	Efficiency: a string property, it is optional.
//Input
//1.	On the first line, you will read a number N,
//which will specify how many lines of engines you will receive.
//•	On each of the next N lines, you will receive information about an Engine
//in the following format: "{model} {power} {displacement} {efficiency}"
//•	Keep in mind that "displacement" and "efficiency" are optional,
//they could be missing from the command.
//2.	Next, you will receive a number M,
//which will specify how many lines of car you will receive.
//•	On each of the next M lines, you will receive information about a Car
//in the following format: "{model} {engine} {weight} {color}".
//•	Keep in mind that "weight" and "color" are optional, they could be missing from the command.
//•	The "engine" will always be the model of an existing Engine.
//•	When creating the object for a Car, you should keep a reference to the real engine in it,
//instead of just the engine’s model. 
//Note: The optional properties might be missing from the formats.
//Output
//Your task is to print all the cars in the order they were received
//and their information in the format defined below.
//If any of the optional fields are missing, print "n/a" in its place:
//"{CarModel}:
//  { EngineModel}:
//    Power: { EnginePower}
//Displacement: { EngineDisplacement}
//Efficiency: { EngineEfficiency}
//Weight: { CarWeight}
//Color: { CarColor}
//"
//Bonus*
//Override the classes' "ToString()" methods to have a reusable way of displaying the objects.


using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Engine> engines = new List<Engine>();
            int numberOfEngines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfEngines; i++)
            {
                engines.Add(GetNewEngineData());
            }

            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(GetNewCarData(engines));
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public static Engine GetNewEngineData()
        {
            string[] engineData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);            
            string model = engineData[0];
            int power = int.Parse(engineData[1]);
            switch (engineData.Length)
            {
                case 2:
                    return new Engine(model, power);
                case 3:
                    string item = engineData[2];
                    bool isItAnInteger = int.TryParse(item, out _);

                    if (isItAnInteger)
                        return new Engine(model, power, int.Parse(item));
                    else
                        return new Engine(model, power, item);
                case 4:
                    int displacement = int.Parse(engineData[2]);
                    string efficiency = engineData[3];
                    return new Engine(model, power, displacement, efficiency);
                default: 
                    return null;
            }            
        }

        public static Car GetNewCarData(List<Engine> engines)
        {
            string[] carData = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);            
            string model = carData[0];
            string engineModel = carData[1];
            Engine engine = engines.Find(e => e.Model == engineModel);
            switch (carData.Length)
            {
                case 2:
                    return new Car(model, engine);
                case 3:
                    string item = carData[2];
                    bool isItAnInteger = int.TryParse(item, out _);

                    if (isItAnInteger)
                        return new Car(model, engine, int.Parse(item));
                    else
                        return new Car(model, engine, item);
                case 4:
                    int weight = int.Parse(carData[2]);
                    string color = carData[3];
                    return new Car(model, engine, weight, color);
                default:
                    return null;
            }
        }
    }
}
