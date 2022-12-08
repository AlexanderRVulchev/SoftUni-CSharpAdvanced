Your task is to create an airfield where drones can take of and land.
Drone
You are given a class Drone,  create the following fields:
•	Name: string
•	Brand: string
•	Range: int
•	Available: boolean - true by default
The class constructor should receive (name, brand, range). 
The class should also have a method:
•	Override the ToString() method in the format:
     "Drone: {name}
Manufactured by: {brand}
Range: {range} kilometers"

Airfield
Next, a class named Airfield is given that has a collection (drones) of type Drone. The name of the collection should be Drones. All the entities of the Drones collection have the same properties.  The Airfield has also some additional properties:
•	Name: string
•	Capacity: int
•	LandingStrip - double
The constructor of the Airfield class should receive the name, capacity, and landing strip.
Implement the following features:
•	Getter Count - returns the count of the drones in the airfield.
•	string AddDrone(Drone drone) - adds a drone to the drone's collection if there is room for it. Before adding a drone, check:
•	If the name or brand are null or empty.
•	If the range is NOT between 5-15 kilometers.
If the name, brand, or range properties are not valid, return: "Invalid drone.". If the airfield is full (there is no room for more drones), return "Airfield is full.". Otherwise, return: "Successfully added {droneName} to the airfield."
•	bool RemoveDrone(string name) - removes a drone by given name, if such exists return true, otherwise false.
•	int RemoveDroneByBrand(string brand) - removes all drones by the given brand, if such exists, return how many drones were removed, otherwise 0.
•	Drone FlyDrone(string name) method – fly (set its available property to false without removing it from the collection) the drone with the given name if exists. As a result return the drone, or null if does not exist.
•	List<Drone> FlyDronesByRange(int range) method - fly and returns all drones which have a range equal or bigger to the given. Return a list of all drones which have been flown. The range will always be valid.
•	Report() - returns information about the airfield and drones which are not in flight in the following format:	
o	"Drones available at {airfieldName}:
{Drone1}
{Drone2}
(…)"
Note: Do not use "\n\r" for a new line. 
Constraints
•	The names of the drones will be always unique.
•	You will always have a drone added before receiving methods manipulating the Airfield’s drones.
