Your task is to create a repository, which stores items by creating the classes described below.
First, write a C# class Car with the following properties:
•	Manufacturer: string
•	Model: string
•	Year: int
The class constructor should receive manufacturer, model and year and override the ToString() method in the following format:
"{manufacturer} {model} ({year})"
Next, write a C# class Parking that has data (a collection, which stores the entity Car). All entities inside the repository have the same properties. Also, the Parking class should have those properties:
•	Type: string
•	Capacity: int
The class constructor should receive type and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
•	Field data – collection that holds added cars
•	Method Add(Car car) – adds an entity to the data if there is an empty cell for the car.
•	Method Remove(string manufacturer, string model) – removes the car by given manufacturer and model, if such exists, and returns bool.
•	Method GetLatestCar() – returns the latest car (by year) or null if have no cars.
•	Method GetCar(string manufacturer, string model) – returns the car with the given manufacturer and model or null if there is no such car.
•	Getter Count – returns the number of cars.
•	GetStatistics() – returns a string in the following format:
o	"The cars are parked in {parking type}:
{Car1}
{Car2}
(…)"
Constraints
•	The combinations of manufacturers and models will be always unique.
•	The year of the cars will always be positive.
•	There won't be cars with the same years.
