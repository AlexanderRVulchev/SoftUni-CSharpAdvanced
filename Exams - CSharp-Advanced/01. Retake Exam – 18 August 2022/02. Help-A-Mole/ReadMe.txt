02. Help-A-Mole
Everybody knows the famous Whac-A-Mole game, where you have to hit the mole and earn points. This time you are going to play Help-A-Mole, because the Mole is tired of being chased and hit and he asked you to help him survive yet another game.
You will be given a number n, which will represent the size of the playing field (square shape). On the next n lines, you will receive the rows of the field. The Mole will be placed on a random position, marked with the letter 'M'. At random positions, there will be single digits, representing points that the Mole earns, in order to win the game. 
There will be two (2) special locations, which help the Mole move faster around the field. They will be marked with 'S'. If the Mole lands on a special location, he will be teleported to the other one. After the Mole is teleported to the other special location, he loses three (3) points and both of the special locations dissapear. This means that the first one must be marked with a dash '-'.
All of the other locations will be marked with a dash '-'.
On each turn, you will be given commands that guide the Mole through the playing field in order to escape the hits. The commands will be 'up', 'down', 'left' and 'right'. If you receive a command that guides the Mole out of the playing field, you must print "Don't try to escape the playing field!" and continue with the next command. After the Mole moves to the new position, in all cases you should mark the previous one with a dash '-'.
The program ends when the "End" command is given or when the Mole collects at least 25 points.
Input
•	On the first line, you are given the integer n – the size of the matrix (playing field).
•	The next n lines hold the values for every row.
•	On each of the next lines, until you receive the "End" command, you will get a move command.
Output
•	On the first line print:
o	If the Mole collected 25 points or more: "Yay! The Mole survived another game!"
o	If the Mole didn't collect 25 points or more: "Too bad! The Mole lost this battle!"
•	On the second line, depending on whether the Mole won the game or not, print:
o	If the Mole won the game: "The Mole managed to survive with a total of {totalAmountOfCollectedPoints} points."
o	If the Mole lost the game: "The Mole lost the game with a total of {totalAmountOfCollectedPoints} points."
•	If the direction commands guide the Mole out of the playing field, print "Don't try to escape the playing field!".
•	At the end, print the final state of the matrix (playing field) with the Mole's position on it.
Constraints
•	The size of the square matrix (playing field) will be between [2…10].
•	There will always be 2 special places on the wall, marked with 'S'.
•	The Mole's starting position will always be marked with an 'M'.
•	There may be cases where the given directions will be outside of the wall.
•	There will be no cases, in which the Mole's points will be below zero (0).
•	There will be always two output scenarios: 
o	The Mole collects at least 25 points and the program ends;
o	The program receives the "End" command before the Mole manages to collect 25 points.
