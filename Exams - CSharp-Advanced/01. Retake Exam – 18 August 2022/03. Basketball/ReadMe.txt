03. Basketball Players
One of your best friends is the manager of the National Amateur Basketball League. He asked you to create a program, which will help him manage the players and their teams.
1.	Preparation
Download the skeleton provided in Judge. Do not change the StartUp class or its namespace.
Note: The target framework of your project must be .NET Core 3.1.
2.	Problem description
Your task is to create a catalog of teams, containing information for various basketball players.
Player
You are given a class Player,  create the following properties:
•	Name: string
•	Position: string
•	Rating: double
•	Games: int
•	Retired: boolean – false by default
The class constructor should receive (name, position, rating, games). 
The class should also have a method:
•	Override the ToString() method in the format:
     "-Player: {name}
--Position: {position}
--Rating: {rating}
--Games played: {games}"
Team
Next, a class named Team is given, that has a collection (players) of type Player. All the entities of the Players collection have the same properties. The Team has also some additional properties:
•	Name: string
•	OpenPositions: int
•	Group: char
The constructor of the Team class should receive the name, openPositions and group.
Implement the following features:
•	Getter Count - returns the count of the players in the team.
•	string AddPlayer(Player player) – adds a player to the team's collection, if there are open positions. Before adding a player, check:
o	If the name or position is null or empty, return "Invalid player's information.".
o	If there are no more open positions, return "There are no more open positions.". 
o	If the rating is under 80, return "Invalid player's rating.".
o	Otherwise, return: "Successfully added {playerName} to the team. Remaining open positions: {openPositions}." and decrease the OpenPositions property of the team.
•	bool RemovePlayer(string name) – removes a player by given name.
o	If such exists, returns true;
o	Otherwise, returns false.
Note: Remember to update the OpenPositions property!
•	int RemovePlayerByPosition(string position) – removes all players by the given position.
o	If such exist(s), returns the count of the removed players;
o	Otherwise, returns 0.
Note: Remember to update the OpenPositions property!
•	Player RetirePlayer(string name) method – retire (set his Retired property to true, without removing him from the collection) the player with the given name, if he exists. As a result, return the player, or null, if he don't exist.
•	List<Player> AwardPlayers (int games) method – return a list with all players that have participated in games games or more.
•	Report() – returns a string with information about the team and players who are not retired in the following format:	
"Active players competing for Team {team} from Group {group}:
{Player1}
{Player2}
{…}"
Note: Do not use "\n\r" for a new line. 
Constraints
•	The names of the players will be always unique.
•	You will always have a player added before receiving methods, manipulating the teams' players.
Examples
This is an example of how the Team class is intended to be used. 
