Peter loves spinning fishing, and he needs a portable fishing net, where he can store his catch. 
Fish
You are given a class Fish,  create the following fields:
•	FishType: string
•	Length: double
•	Weight: double
The class constructor should receive fish type, length, and weight. 
The class should also have a method:
•	Override the ToString() method in the format: "There is a {fishType}, {length} cm. long, and {weight} gr. in weight."
Net
Next, a class named Net is given that has a collection (fish) of type Fish. The name of the collection should be Fish, which could not be modified. All the entities of the Fish collection have the same properties.  The Net also has some additional properties:
•	Material: string
•	Capacity: int
The constructor of the Net class should receive the material, and capacity.
Implement the following features:
•	Getter Count - returns the total count of the fish in the net.
•	string AddFish(Fish fish) - adds a Fish to the fish's collection if there is room for it. Before adding a fish, check:
•	If the fish type is null or whitespace.
•	If the fish’s length or weight is zero or less.
If the fish type, length, or weight properties are not valid, return: "Invalid fish.". If the net is full (there is no room for more fish), return "Fishing net is full.". Otherwise, return: "Successfully added {fishType} to the fishing net."
•	bool ReleaseFish(double weight) – removes a fish by given weight, if such exists return true, otherwise false.
•	Fish GetFish(string fishType) – search and returns a fish by given fish type.
•	Fish GetBiggestFish()– search and returns the longest fish in the collection.
•	Report() - returns information about the Net and all fish that were not released, order by fish's length descending  in the following format:	
o	"Into the {material}:
{Fish1}
{Fish2}
(…)"
Note: Do not use "\n\r" for a new line. 
Constraints
•	You will always have a fish added before receiving methods that manipulate the fish in the Net.
Examples
This is an example of how the Net class is intended to be used. 
