Create a program that helps Peter to pick up truffles. There are three kinds of truffles in the forest:
•	Black truffle - 'B'
•	Summer truffle - 'S'
•	White truffle - 'W'
On the first line, the size of the forest is given, which will be a matrix with a square shape. Then for each row, you will receive the truffles. All of the empty positions will be marked with a '-' (dash).
Then you will start receiving commands. Here are the possible ones you can receive:
•	"Collect {row} {col}" - Peter goes to the given place in the forest and collect the truffle if it exists. When he collects a truffle, the cell’s should be change to a dash ('-').
•	"Wild_Boar {row} {col} {direction}" - a wild boar appeirs in the given coordinates (they will be always valid) in the forest and it goes all the way in that direction. Which means the wild boar, goes from the given cell to the last cell in the given direction. It eats the given cell, skips the next, and eats the next one, if there is a truffle there, and so on until it reaches the last cell in the given direction. Mark the eaten cells with a dash ('-'). There are four possible directions:
o	"up", "down", "left", and "right"
•	"Stop the hunt" – the program stops and the result is printed.
Here is an example (up and right) of the wild boar eating pattern: 
 
In the end, print the truffles that Peter have successfully found and the count of truffles that the wild boar ate in the following format:
"Peter manages to harvest {count black truffles} black, {count summer truffles} summer, and {count white truffles} white truffles."
"The wild boar has eaten {count of truffles} truffles."
Then print the last state of the forest.
Input
•	On the first line, you will receive the size of the forest (matrix) in square shape.
•	On the next lines, for each row, you will receive the truffles in the described format.
•	Next, until you receive "Stop the hunt", you will be receiving commands in the described format.
Output
As an output print three lines:
•	All types of truffles that Peter has collected in the format described above.
•	Truffles eaten by the wild boar in the format described above.
•	The final state of the forest - each cell separated by a single space.
Constraints
•	The size of the square matrix will be between [3…10].
•	The coordinate of the wild boar will be always valid.
•	The input will always be valid and you don't need to check it explicitly.
