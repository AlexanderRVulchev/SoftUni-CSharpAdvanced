After Mario gets into the tower, he has to fight his way to the princess. In order to do that, he has to walk through the maze where the dangerous Bowser is guarding, but he also has to be careful not to loose all his lives and not be able to proceed with his mission. If Mario successfully reaches the throne, he saves princess Peach.
The castles maze may looks like this:
The Maze	Legend
------P---
-------B--
--B-------
----------
----M-----	M  Mario, the player character
B Bowser, the enemy
P  Princess Peach
-  Empty space
Each turn proceeds as follows:
•	First, Bowser spawns on the given index.
•	Then, Mario moves in a direction, which decreases his lives by 1.
o	It can be "W" (up), "S" (down), "A" (left), "D" (right).
o	If Mario tries to move outside of the maze, he doesn’t move but still has his lives decreased.
•	If an enemy is on the same cell where Mario moves, Bowser fights him, which decreases his lives by 2. If Mario’s lives drop at 0 or below, he dies and you should mark his position with ‘X’.
•	If Mario kills the enemy successfully, the enemy disappears.
•	If Mario reaches the index where the throne is, he saves Princess Peach and  they both run away (disappear from the field), even if his lives are 0 or below.
1.	Input
•	On the first line of input, you will receive e – the lives Mario has.
•	On the second line of input, you will receive n – the number of rows the castle’s maze will consist of.
Range: [5-20]
•	On the next n lines, you will receive how each row looks.
•	Then, until Mario dies, or reaches the princess, you will receive a move command and spawn row and column.
2.	Output
•	If Mario runs out of lives, print "Mario died at {row};{col}."
•	If Mario reaches the throne, print "Mario has successfully saved the princess! Lives left: {lives}"
•	Then, in all cases, print the final state of the field on the console.
3.	Constraints
•	The field will always be rectangular.
•	Mario will always run out of lives or reach the throne.
•	There will be no case with spawn on invalid index.
•	There will be no case with two enemies on the same cell.
•	There will be no case with enemy spawning on the index where Mario or the princess are.
