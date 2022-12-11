You will be given an integer n for the size of the square matrix and an integer for the count of commands. On the next n lines, you will receive the rows of the matrix. The player starts at a random position (the player is marked with "f") and all of the empty slots will be filled with "-" (dash). The goal is to reach the finish mark which will be marked with "F". On the field there can also be bonuses and traps. Bonuses are marked with "B" and traps are marked with "T".
Each turn you will be given commands for the player’s movement. If the player goes out of the matrix, he comes in from the other side. For example, if the player is on 0, 0 and the next command is left, he goes to the last spot on the first row.
If the player steps on a bonus, he should move another step forward in the direction he is going. If the player steps on a trap, he should move a step backwards.
When the player reaches the finish mark or the count of commands is reached the game ends.
Input
•	On the first line, you are given the integer N – the size of the square matrix.
•	On the second you are given the count of commands.
•	The next N lines holds the values for every row.
•	On each of the next lines you will get commands for movement directions.
Output
•	If the player reaches the finish mark, print: 
o	"Player won!"
•	If the player reaches the commands count and hasn’t reached the finish mark print:
o	"Player lost!"
•	In the end print the matrix.
Constraints
•	The size of the matrix will be between [2…20].
•	The players will always be indicated with "f".
•	If the player steps on the finish mark at the same time as his last command, he wins the game.
•	Commands will be in the format up, down, left or right.
•	There won't be a case where you bypass the finish while you are on a trap or a bonus.
•	A trap will never place you into a bonus or another trap and a bonus will never place you into a trap or another bonus.
