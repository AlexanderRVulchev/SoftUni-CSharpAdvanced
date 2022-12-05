01. Tiles Master
Summer is coming which means it's that time of the year when everybody is renovating their home…
Victoria wants to renovate her apartment, too. She's starting with the kitchen and she has hired a handyman to put new tiles on the walls and the floor. She wants a modern kitchen and she has bought fancy tiles, which must be put in an exact order and locations to achieve the glamorous look of the kitchen that she expects.
Unfortunately, the tiles come in different sizes and colours, and your task is to help Victoria and the handyman Vanko place them in the right order and location in the kitchen.
First, you will be given a sequence of numbers, representing the areas of the white tiles. Afterward, you will be given another sequence, representing the areas of the grey tiles.
You start from the first grey tile and compare its area to the area of the last white tile.
If their areas are equal, together they form a new larger tile, that the handyman will be able to use. After that, you should check whether the area of the new-formed tile matches one of the numbers in the table below (the numbers correspond to a particular location in the kitchen). The area of the new tile is formed by summing the areas of the white and the grey tile.
If the area of the new-formed tile matches the necessary area tile for any of the locations in the kitchen, you should remove both the grey and white tiles from the sequences. If the area doesn't match any of the specified locations, the new tile will be used for a location, named Floor. 
If their areas don't match at all, you take the white tile, decrease its area in half and insert it back to the sequence. After that, you change the grey's tile position by putting it at the back of the sequence.

Location	Tile area needed
Sink	40
Oven	50
Countertop	60
Wall	70

Compare all of the areas while keeping track of the tiles that will be used for the particular locations in the kitchen. You stop comparing them in case the handyman is both out of white and grey tiles, or in case any one of them is out. Finally, print the number of tiles that will be used for the different locations. 
Input
•	On the first line, you will receive the areas of the white tiles, separated by a single space (' '). 
•	On the second line, you will receive the areas of the grey tiles, separated by a single space (' ').
Output
•	On the first line – print all white tiles you have left:
o	If there are no white tiles left: "White tiles left: none"
o	If there are white tiles left: "White tiles left: {whiteTile1}, {whiteTile2}, {whiteTile3}, (…)"
•	On the second line - print all grey tiles you have left:
o	If there are no grey tiles left: "Grey tiles left: none"
o	If there are grey tiles left: "Grey tiles left: {greyTile1}, {greyTile2}, {greyTile3}, (…)"
•	Then, you need to print only the locations in the kitchen that will be decorated with the new-formed tiles (including the floor), and the count of new tiles that will be used for them. The locations must be ordered descending by number (count of new tiles per location) and then sorted ascending alphabetically.
o	"Countertop: {amount}"
o	"Floor: {amount}"
o	"Oven: {amount}"
o	"Sink: {amount}"
o	"Wall: {amount}"

Constraints
•	All of the given numbers will be valid integers in the range [0…200].
•	There will be no case where the white tiles' area reaches 0.
•	The areas of the white tiles that must be divided in half will always be even numbers.
