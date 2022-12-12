We get as input the size of the field in which our Warships are situated. The field is always a square. After that we will receive the coordinates for the attacks for each player in pairs of integers (row, column). If there is an attack on invalid coordinates - ignore the attack. The possible characters that may appear on the screen are:
•	* – a regular position on the field
•	< – ship of the first player.
•	> – ship of the second player
•	# – a sea mine that explodes when attacked
Each time when an attack hits a ship or a mine replace it with 'X'. Keep track of the count of ships remaining for each player. If a player hits a mine it explodes destroying all ships in adjacent fields (friend or foe). If a player destroys all enemy ships, the program stops and you have to print the following message: "Player {One/Two} has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle."
If the list of attack commands ends before any of the player has won, you have to print the following message:     
"It's a draw! Player One has {countOfShips} left. Player Two has {countOfShips} left."
Input
•	Field size – an integer number.
•	Attack commands – All attack coordinates will be received on a single line. There will be a coma (,) between each set of coordinates and a whitespace (" ") between every two integers representing the row and column to attack.
•	The field: some of the following characters (*, <, >, #), separated by whitespace (" ");
Output
•	There are three types of output:
o	If player One wins, print the following output: "Player One has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle."
o	If player Two wins, print the following output: "Player Two has won the game! {totalCountShipsDestroyed} ships have been sunk in the battle."
o	If there are no more commands and none of the above cases had happened, you have to print the following message: "It's a draw! Player One has {countOfShips} ships left. Player Two has {countOfShips} ships left."
Constraints
•	The field size will be a 32-bit integer in the range [4 … 2 147 483 647].
•	Player One always starts first.
•	A player will never attack the coordinates of one of his own ships. 
•	There will be no incomplete sets of attack coordinates – e.g. – "0 1,2 3,2".
•	There will never be 2 mines in adjacent fields.
•	There will not be a test where both players lose their last ships in the same turn.
