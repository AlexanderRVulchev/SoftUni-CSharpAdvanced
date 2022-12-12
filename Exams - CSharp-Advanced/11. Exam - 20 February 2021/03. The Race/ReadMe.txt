Your task is to create a repository, which stores departments by creating the classes described below.
First, write a C# class Car with the following properties:
•	Name: string
•	Speed: int
The class constructor should receive name, and speed.
Next, write a C# class Racer with the following properties:
•	Name: string
•	Age: int
•	Country: string
•	Car: Car
The class constructor should receive name, age, country and Car and override the ToString() method in the following format:
"Racer: {name}, {age} ({country})"
Next, write a C# class Race that has data (a collection, which stores the entity Racer). All entities inside the repository have the same properties. Also, the Race class should have those properties:
•	Name: string
•	Capacity: int
The class constructor should receive name and capacity (the maximum allowed number of racers), also it should initialize the data with a new instance of the collection. Implement the following features:
•	Field data – collection that holds added Racers
•	Method Add(Racer Racer) – adds an entity to the data if there is room for him/her.
•	Method Remove(string name) – removes an Racer by given name, if such exists, and returns bool.
•	Method GetOldestRacer() – returns the oldest Racer.
•	Method GetRacer(string name) – returns the Racer with the given name.
•	Method GetFastestRacer() – returns the Racer whose car has the highest speed.
•	Getter Count – returns the number of Racers.
•	Report() – returns a string in the following format:
o	"Racers participating at {RaceName}:
{Racer1}
{Racer2}
(…)"
Constraints
•	The names of the Racers will be always unique.
•	The age of the Racers will always be with positive values.
•	You will always have a Racer added before receiving methods manipulating the Race’s data.
