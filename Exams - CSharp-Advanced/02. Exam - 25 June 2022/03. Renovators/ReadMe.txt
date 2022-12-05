03. Renovators
Despite your efforts and directions, Vanko totally destroyed Victoria's wall. Now she wants to choose another handyman, but this time she'll be more careful. That's why she asked you to help her and create a catalog with different renovators and their info.
1.	Preparation
Download the skeleton provided in Judge. Do not change the StartUp class or its namespace.
Note: The target framework of your project must be .NET Core 3.1.
2.	Problem description
Your task is to create a catalog, containing information for various renovators.
Renovator
You are given a class Renovator,  create the following fields:
•	Name: string
•	Type: string
•	Rate: double
•	Days: int
•	Hired: boolean - false by default
The class constructor should receive (name, type, rate, days). 
The class should also have a method:
•	Override the ToString() method in the format:
     "-Renovator: {name}
--Specialty: {type}
--Rate per day: {rate} BGN"

Catalog
Next, a class named Catalog is given that has a collection (renovators) of type Renovator. All the entities of the renovators collection have the same properties. The Catalog has also some additional properties:
•	Name: string
•	NeededRenovators: int
•	Project: string
The constructor of the Catalog class should receive the name, neededRenovators and project.
Implement the following features:
•	Getter Count - returns the count of the renovators in the catalog.
•	string AddRenovator(Renovator renovator) - adds a renovator to the catalog's collection, if renovators are still needed. Before adding a renovator, check:
o	If the name or specialty are null or empty, return "Invalid renovator's information.".
o	If renovators are no more needed, return "Renovators are no more needed.". Renovators are needed when the count of the added renovators is less than the NeededRenovators property of the Catalog.
o	If the rate is above 350 BGN, return "Invalid renovator's rate.".
o	Otherwise, return: "Successfully added {renovatorName} to the catalog.".
•	bool RemoveRenovator(string name) - removes a renovator by given name.
o	If such exists returns true;
o	Otherwise, returns false.
•	int RemoveRenovatorBySpecialty(string type) - removes all renovators by the given specialty.
o	If such exist(s), returns the count of the removed renovators;
o	Otherwise, returns 0.
•	Renovator HireRenovator(string name) method – hire (set their available property to true without removing them from the collection) the renovator with the given name, if they exist. As a result, return the renovator, or null, if they don't exist.
•	List<Renovator> PayRenovators (int days) method – return a list with all renovators that have been working for days days or more.
•	Report() – returns a string with information about the catalog and renovators who are not hired in the following format:	
"Renovators available for Project {project}:
{Renovator1}
{Renovator2}
{…}"
Note: Do not use "\n\r" for a new line. 
Constraints
•	The names of the renovators will be always unique.
•	You will always have a renovator added before receiving methods manipulating the catalogs' renovators.
