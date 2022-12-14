Your task is to create a repository, which stores items by creating the classes described below.
First, write a C# class Pet with the following properties:
•	Name: string
•	Age: int
•	Owner: string
The class constructor should receive name, age and owner. The class should override the ToString() method in the following format:
"Name: {Name} Age: {Age} Owner: {Owner}"
Next, write a C# class Clinic that has data (a collection, which stores the Pets). All entities inside the repository have the same properties. Also, the Clinic class should have those properties:
•	Capacity: int
The class constructor should receive capacity, also it should initialize the data with a new instance of the collection. Implement the following features:
•	Field data – collection that holds added pets
•	Method Add(Pet pet) – adds an entity to the data if there is an empty cell for the pet.
•	Method Remove(string name) – removes the pet by given name, if such exists, and returns bool.
•	Method GetPet(string name, string owner) – returns the pet with the given name and owner or null if no such pet exists.
•	Method GetOldestPet() – returns the oldest Pet.
•	Getter Count – returns the number of pets.
•	GetStatistics() – returns a string in the following format:
o	"The clinic has the following patients:
Pet {Name} with owner: {Owner}
Pet {Name} with owner: {Owner}
   (…)"
Constraints
•	The combinations of names and owners will always be unique.
•	The age of the pets will always be positive.
