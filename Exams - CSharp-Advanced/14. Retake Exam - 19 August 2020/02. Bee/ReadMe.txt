You will be given an integer n for the size of the bee territory with square shape. On the next n lines, you will receive the rows of the territory. The bee will be placed on a random position, marked with the letter 'B'. On random positions there will be flowers, marked with 'f'. There may also be а bonus on the territory. There will always be only one bonus. It will be marked with the letter - 'O'. All of the empty positions will be marked with '.'.
Each turn, you will be given a command for the bee’s movement.
The commands will be: "up", "down", "left", "right", "End".
If the bee moves to a flower, it pollinates the flower and increases the pollinated flowers with one.
If it goes to a bonus, the bee gets a bonus one move forward and then the bonus disappears. If the bee goes out she can't return back and the program ends. If the bee receives the "End" command the program ends. The bee needs at least 5 pollinated flowers.
Input
•	On the first line, you are given the integer n – the size of the square matrix.
•	The next n lines hold the values for every row.
•	On each of the next lines, until you receive "End" command,  you will receive a move command.
Output
•	On the first line:
o	If the bee goes out of its territory print: "The bee got lost!"
•	On the second line:
o	 If the bee couldn’t pollinate enough flowers, print: "The bee couldn't pollinate the flowers, she needed {needed} flowers more"
o	If the bee successfully pollinated enough flowers, print: "Great job, the bee managed to pollinate {polinationed flowers} flowers!"
•	In the end print the matrix.
Constraints
•	The size of the square matrix will be between [2…10].
•	There will always be 0 or 1 bonus, marked with - 'O'.
•	The bee position will be marked with 'B'.
•	There won't be a case where a bonus moves the bee out of its territory.
