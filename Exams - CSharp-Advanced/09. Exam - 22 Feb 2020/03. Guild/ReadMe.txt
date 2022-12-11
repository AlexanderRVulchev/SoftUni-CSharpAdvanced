Your task is to create a repository which stores players by creating the classes described below.
First, write a C# class Player with the following properties:
•	Name: string
•	Class: string
•	Rank: string – "Trial" by default
•	Description: string – "n/a" by default
The class constructor should receive name and class. Override the ToString() method in the following format:
"Player {Name}: {Class}
Rank: {Rank}
Description: {Description}"
Next, write a C# class Guild that has a roster (a collection which stores the entity Player). All entities inside the repository have the same properties. Also, the Guild class should have those properties:
•	Name: string
•	Capacity: int
The class constructor should receive name and capacity, also it should initialize the roster with a new instance of the collection. Implement the following features:
•	Field roster - collection that holds added players
•	Method AddPlayer(Player player) - adds an entity to the roster if there is room for it
•	Method RemovePlayer(string name) - removes a player by given name, if such exists, and returns bool
•	Method PromotePlayer(string name) - promote (set his rank to "Member") the first player with the given name. If the player is already a "Member", do nothing.
•	Method DemotePlayer(string name)- demote (set his rank to "Trial") the first player with the given name. If the player is already a "Trial",  do nothing.
•	Method KickPlayersByClass(string class) - removes all the players by the given class and returns all players from that class as an array
•	Getter Count - returns the number of players
•	Report() - returns a string in the following format:	
o	"Players in the guild: {guildName}
{Player1}
{Player2}
(…)"
