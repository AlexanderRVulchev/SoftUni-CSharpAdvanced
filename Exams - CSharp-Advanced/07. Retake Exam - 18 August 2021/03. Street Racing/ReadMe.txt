Your task is to create a race in which participate different cars.
Car
 First, write a C# class, called Car with properties:
•	Make: string
•	Model: string
•	LicensePlate: string
•	HorsePower: int
•	Weight: double
The constructor of Car class should receive make, model, licensePlate, horsePower and weight.
The class should also have the following methods:
•	Override ToString() method in the format:
"Make: {Make}
 Model: {Model}
 License Plate: {LicensePlate}
 Horse Power: {HorsePower}
 Weight: {Weight}"
Race
Next step is to write Race class that has a collection of type Car with corresponding unique License Plate of a Car. The name of the collection should be Participants. All the entities of the Participants collection have the same properties. The Race has also some additional properties:
•	Name: string
•	Type: string
•	Laps: int
•	Capacity: int - the maximum allowed number of participants in the race
•	MaxHorsePower: int - the maximum allowed Horse Power of a Car in the Race
The constructor of the Race class should receive name, type, laps, capacity and maxHorsePower.
 
Implement the coming features:
•	Getter Count - returns the count of the currently enrolled participants
•	Method Add(Car car) - adds the entity if there isn't a Car with the same License plate and if there is enough space in terms of race capacity and if the car meets the maximum horse power requirment of the race.
•	Method Remove(string licensePlate) - removes a Car from the race with the given License plate, if such exists and returns bool if the deletion is successful.
•	Method FindParticipant(string licensePlate) - returns a Car with the given License plate. If it doesn't exist, return null.
•	Method GetMostPowerfulCar() – returns the Car with most HorsePower. If there are no Cars in the Race, method should return null. 
•	Method Report() - returns information about the Race and the Cars participating it in the following format:
"Race: {Name} - Type: {Type} (Laps: {Laps})
{Car1}
{Car2}
… "
3.	Constraints
•	The License plate of each Car in the race will always be unique
•	The HorsePower of a Car and the MaxHorsePower of the Race will always be positive numbers
•	There will not be a case where two Cars have the same HorsePower
•	You will always be given Car added before receiving method for its manipulation 
