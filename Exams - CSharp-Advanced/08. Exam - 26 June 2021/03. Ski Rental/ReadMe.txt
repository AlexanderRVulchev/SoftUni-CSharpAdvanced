Your task is to create a repository, which stores items by creating the classes described below.
First, write a C# class Ski with the following properties:
•	Manufacturer: string
•	Model: string
•	Year: int
The class constructor should receive manufacturer, model and year and override the ToString() method in the following format:
"{manufacturer} - {model} - {year}"
Next, write a C# class SkiRental that has data (a collection, which stores the entity Ski). All entities inside the repository have the same properties. Also, the Ski Rental class should have those properties:
•	Name: string
•	Capacity: int
The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
•	Field data – collection that holds added Skis
•	Method Add(Ski ski) – adds an entity to the data if there is an empty slot for the Ski.
•	Method Remove(string manufacturer, string model) – removes the Ski by given manufacturer and model, if such exists, and returns bool.
•	Method GetNewestSki() – returns the newest Ski (by year) or null if there are no Skis stored.
•	Method GetSki(string manufacturer, string model) – returns the Ski with the given manufacturer and model or null if there is no such Ski.
•	Getter Count – returns the number of Skis.
•	GetStatistics() – returns a string in the following format:
o	"The skis stored in {Ski Rental Name}:
{Ski1}
{Ski2}
(…)"


Constraints
•	The combinations of manufacturers and models will be always unique.
•	The year of the Skis will always be positive.
•	There won't be Skis with the same years.
