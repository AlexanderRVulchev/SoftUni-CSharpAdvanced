You will be given an integer n for the size of the armory with a square shape. On the next n lines, you will receive the rows of the armory. The army officer will be placed in a random position, marked with the letter 'A'. On random positions, there will be swords, marked with a single digit (the price of the sword). There may also be mirrors, the count will be either 0 or 2 and they are marked with the letter - 'M'. All of the empty positions will be marked with '-'.
Each turn, you will tell the army officer which direction he should move. Move commands will be: "up", "down", "left", "right". If the army officer moves to a sword, he buys the sword for a price equal to the digit there and the sword disappears. If the army officer moves to a mirror, he teleports on the position of the other mirror, and then both mirrors disappear. If you guide the army officer out of the armory, he leaves with the swords that he has bought. In advance, you negotiate with the king, that he'll buy at least 65 gold coins worth of blades.
The program ends when the army officer buys blades for at least 65 gold coins, or you guide him out of the armory.
Input
•	On the first line, you are given the integer n – the size of the matrix (armory).
•	The next n lines hold the values for every row.
•	On each of the next lines, you will get a move command.
Output
•	On the first line:
o	If the army officer leaves the armory, print: "I do not need more swords!"
o	If the army officer fulfills the initial deal, print: "Very nice swords, I will come back for more!"
•	On the second line print the profit you’ve made: "The king paid {amount} gold coins."
•	At the end print the final state of the matrix (armory).
Constraints
•	The size of the square matrix (armory) will be between [2…10].
•	There will always be 0 or 2 mirrors, marked with the letter - 'M'.
•	The army officer’s position will be marked as 'A'.
•	There will be always two output scenarios: the army officer leaves or bays swords worth at least 65 gold coins.
 
