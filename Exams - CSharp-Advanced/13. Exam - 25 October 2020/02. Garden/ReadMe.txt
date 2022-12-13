You will be given N and M – integers, indicating the dimensions of the square garden. The garden is empty at the beginning – it has no flowers. Furion wants every place for a flower to be presented with a zero (0) when it is empty. After you finish creating the garden, you will start receiving two integers – Row and Column, separated by a single space – which represent the position at which Furion currently plants a flower. If you receive a position, which is outside of the garden, you should print "Invalid coordinates." and move on with the next position. This happens until you receive the command "Bloom Bloom Plow”. When you receive that input, all planted flowers should bloom.
The flowers are magical. When a flower blooms it instantly blooms flowers to all places to its left, right, up, and down, increasing their value with 1. Flowers can bloom multiple times, and each time the flower blooms – it becomes more and more beautiful, which means its value increases by 1. 
Input
•	On the first line of input you will receive two integers, separated by a single space – indicating the dimensions of the garden.
•	On the next several lines you will be receiving two integers separated by a single space – indicating the position at which Furion currently plants a flower.
•	When you receive the input line "Bloom Bloom Plow” the input sequence should end.
Output
•	Print "Invalid coordinates." each time you receive positions outside the garden.
•	The output is simple. Print the whole garden – each row of it on a new line, and each column – separated by a single space.
Constraints
•	The dimensions of the matrix (N and M) will contains be integers in the range [3, 500].
•	The amount of input commands will be in the range [0, N * M].
•	Flowers will always be planted on empty places.
