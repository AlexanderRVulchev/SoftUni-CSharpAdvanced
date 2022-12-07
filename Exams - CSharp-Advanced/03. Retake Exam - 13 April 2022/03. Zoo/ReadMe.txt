Create software that keeps track of the animals in a zoo.
Animal
You are given a class Animal,  create the following fields:
•	Species – string
•	Diet – string
•	Weight – double
•	Length – double
The class constructor should receive species, diet, weight, and length. 
Override ToString() method: "The {animal specie} is a {diet} and weighs {weight} kg."
Zoo
Next, a class named Zoo is given that has a collection (animals) of type Animal. The name of the collection should be Animals, which could not be modified. All the entities of the Animal collection have the same properties.  The Zoo also has some additional properties:
•	Name: string
•	Capacity: int
The constructor of the Zoo class should receive the name, and capacity.
Implement the following features:
•	string AddAnimal(Animal animal) –  adds an Animal to the animals' collection if there is room for it. Before adding an animal, check:
	If the animal species is null or whitespace, return "Invalid animal species."
	If the animal’s diet is different from "herbivore" or "carnivore", return "Invalid animal diet."
	If the zoo is full (there is no room for more animals), return "The zoo is full."
	Otherwise, return: "Successfully added {animal species} to the zoo."
•	int RemoveAnimals(string species) – removes all animals by given species, as a result, return the count of the animals which were removed.
•	List<Animal> GetAnimalsByDiet(string diet) – search and returns a list of animals by given diet.
•	Animal GetAnimalByWeight(double weight) – return the first animal, with the given weight.
•	string GetAnimalCountByLength(double minimumLength, double maximumLength) – search of all animals which has a length between the given (inclusively). As a result return the following format: "There are {count} animals with a length between {minimum length} and {maximum length} meters."
Constraints
•	You will always have an animal added before receiving methods that manipulate the animals in the Zoo.
