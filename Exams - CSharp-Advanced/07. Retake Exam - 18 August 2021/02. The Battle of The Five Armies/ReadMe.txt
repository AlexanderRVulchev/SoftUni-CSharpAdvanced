In order to do that, they have to go through the land and fight off the orcs. If they successfully reach Mordor, they will win the fight against the evil.
A standard map of the Middle World looks like this:
The Middle World	Legend
------M---
-------O--
--O-------
----------
-----A----	A  The Army, the player character
O Orcs, enemy
M  Mordor
-  Empty space
Each turn proceeds as follows:
•	First, Orcs spawn on the given index.
•	Then, the army moves in a direction, which decreases their armor by 1.
o	It can be “up”, “down”, “left”, “right”
o	If the army tries to move outside of the field, they don't move but still has their energy decreased.
•	If an enemy is on the same cell where the army moves, the army fights him, which decreases their armor by 2. If the army’s armor drops at 0 or below, they die and you should mark this position with ‘X’.
•	If the army kills the enemy successfully, the enemy disappears.
•	If the army reaches the index where Mordor is, they win the war (disappear from the field), even if their armor is 0 or below.
1.	Input
•	On the first line of input, you will receive e – the armor the army has.
•	On the second line of input, you will receive n – the number of rows the map of the Middle World will consist of.
Range: [5-20]
•	On the next n lines, you will receive how each row looks.
•	Then, until the army dies, or reaches the throne, you will receive a move command and spawn row and column.
2.	Output
•	If the army is runs out of armor, print "The army was defeated at {row};{col}."
•	If the army reaches Mordor, print "The army managed to free the Middle World! Armor left: {armor}"
•	Then, in all cases, print the final state of the map on the console.
3.	Constraints
•	The map will always be rectangular.
•	The army will always run out of armor or reach Mordor.
•	There will be no case with spawn on invalid index.
•	There will be no case with two enemies on the same cell.
•	There will be no case with enemy spawning on the index where the army or Mordor is.
