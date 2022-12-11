First you will be given a sequence of integers representing the hats. Afterwards you will be given another sequence of integers representing the scarfs. 
Check all of the hats and scarfs in order to make sets. Take the last given hat, and the first given scarf and check if the hat is bigger than the scarf and if it is – you have to create a set. A set is created when you add the value of the hat to the value of the scarf (that is the price of the set). If you have a set, remove both the hat and the scarf from their collections. 
If the scarf’s value is bigger – remove the hat and check the next one. 
If their values are equal – remove the scarf and increment the value of the hat with 1
Mary wants to give her mother the most expensive set size, so you have to find out which one it is and print it in the following format:  "The most expensive set is: {maxPriceSet}"
Afterwards print the created sets from the first added to the last, separated by a space. 
Input
•	On the first line of input you will receive the integers, representing the hats, separated by a single space. 
•	On the second line of input you will receive the integers, representing the scarfs, separated by a single space.
Output
•	On the first line of output - print the biggest set in the format specified above. 
•	On the second line - print the sets, separated by a single space in the order specified above.
Constraints
•	All of the given numbers will be valid integers in the range [1, 10000].
•	There will always be at least 1 set.
•	Allowed time/memory: 100ms/16MB.
