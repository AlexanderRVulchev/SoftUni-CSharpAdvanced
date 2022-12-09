You will be given a sequence of integers – each indicating the eating capacity of a single guest. After that you will be given another sequence of integers - the plates. Your job is to make sure everyone is full, so you decide to serve them yourself.
Serving is done exactly one plate at a time. You must start picking from the last stacked plate and start serving from the first entered guest. If the current plate has N grams of food, you give the first entered guest N grams and reduce its integer value by N.
When a guest's integer value reaches 0 or less, it gets removed. It is possible that the current guest's value is greater than the current food's value. In that case you pick plates until you reduce the guest's integer value to 0 or less. If a plate's value is greater or equal to the guest's current value, you fill up the guest and the remaining food becomes wasted. You should keep track of the wasted grams of food and print it at the end of the program. 
If you have managed to fill up all of the guests, print the remaining prepared plates of food, from the last entered – to the first, otherwise you must print the remaining guests, by order of entrance – from the first entered – to the last. 
Input
•	On the first line of input you will receive the integers, representing the guests' capacity, separated by a single space. 
•	On the second line of input you will receive the integers, representing the prepared plates of food, separated by a single space.
Output
•	On the first line of output you must print the remaining plates, or the remaining guests, depending on the case you are in. Just keep the orders of printing exactly as specified. 
o	"Plates: {remainingPlates}" or "Guests: {remainingGuests}"
•	On the second line print the wasted grams of food in the following format: "Wasted grams of food: {wastedGramsOfFood}"
Constraints
•	All of the given numbers will be valid integers in the range [1, 500].
•	It is safe to assume that there will be NO case in which the food is exactly as much as the guests' values, so that at the end there are no guests and no food on the plates.
•	Allowed time/memory: 100ms/16MB.
