You will be given an integer n for the size of the bakery with square shape. On the next n lines, you will receive the rows of the bakery. You will be placed on a random position, marked with the letter 'S'. On random positions there will be clients, marked with a single digit. There may also be pillars. Their count will be either 0 or 2 and they are marked with the letter - 'O'. All of the empty positions will be marked with '-'.
Each turn, you will be given commands for the your movement. Move commands will be: "up", "down", "left", "right". If you move to a client, you collects the price equal to the digit there and the client disappears. If you move to a pillar, you move on the position of the other pillar and then both pillars disappear. If you go out of the bakery, you disappear from the bakery and you are out of there. You need at least 50 dollars to rent your own Bakery
When you are out of the bakery or you collect enough money, the program ends.
Input
•	On the first line, you are given the integer n – the size of the square matrix.
•	The next n lines holds the values for every row.
•	On each of the next lines you will get a move command.
Output
•	On the first line:
o	If the player goes to the void, print: "Bad news, you are out of the bakery."
o	If the player collects enough star power, print: "Good news! You succeeded in collecting enough money!"
•	On the second line print all star power collected: "Money: {money}"
•	In the end print the matrix.
Constraints
•	The size of the square matrix will be between [2…10].
•	There will always be 0 or 2 pillars, marked with the letter - 'O'.
•	Your position will be marked with 'S'.
•	You will always go out of the bakery or collect enough money. 
