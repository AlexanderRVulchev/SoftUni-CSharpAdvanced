A chessboard has 8 rows and 8 columns. Rows also called ranks, are marked from number 1 to 8, and columns are marked from A to H. We have a total of 64 squares, each square is represented by a combination of letters and a number (a1, b1, c1, etc.). In this problem colors of the board will be ignored.
We will play the game with two pawns white (w) and black (b), where they can:
•	Only move forward:
	White (w) moves from the 1st rank to the 8th rank direction.
	Black (b) moves from 8th rank to the 1st rank direction.
•	Can move only 1 square at a time.
•	Can capture another pawn only diagonally:
 
When a pawn reaches the last rank, for white this is the 8th rank, and for black, this is the 1st rank, can be promoted to a queen.

Problem Description
Two pawns (w and b) will be placed on two random squares of the bord. The first move is always made by the white pawn (w), then black moves (b), then white (w) again, and so on. When a pawn marches forward, the previous position is marked by "-" (dash).
Some rules will be applied when moving paws:
•	If the two pawns interact diagonally, the player, in turn, must capture the opponent’s pawn. When a pawn capture another pawn the game is over and "Game over! {white/black} capture on {coordinates}." is printed to the console.
Example:
White pawn is on the move and captures black in "e5". We print "Game over! White capture on e5."
 
•	If no capture is possible, the pawns keep on moving until one of them reaches the last rank. When one of the pawns reaches the last rank we print: "Game over! {White/Black} pawn is promoted to a queen at {coordinates}."
Example:
It is black's turn and the pawn reaches the d1 square, we print "Game over! Black pawn is promoted to a queen at d1."
 
Constraints
•	The input will be always valid.
•	The matrix will always be 8x8.
•	There will be no case where two pawns are placed on the same square.
•	There will be no case where two pawns are placed on the same column.
•	There will be no case where black/white will be placed on the last rank.
