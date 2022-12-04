01. Barista Contest
Nina is a barista and she just signed up for a barista contest, where she has to make as much coffee drinks as possible. She wants to win the contest, that's why she's practicing everyday, so that she can improve her coffee making skills. 
She asked you to help her and create a program that will help her count the types of drinks she manages to make.
Nina makes the drinks with coffee and milk and each of them come in different quantities.
First, you will be given a sequence of numbers, representing the quantities of the coffee. Afterward, you will be given another sequence, representing the quantities of the milk.
You have to start from the first coffee quantity and compare it to the quantity of the last milk.
If the sum of their values is equal to any of the coffee drinks from the table below, it means that Nina is able to make the corresponding drink. In this case, you should remove both quantities from the sequences and continue with the next ones.
If their sum is not equal to any of the drinks from the table, remove the current coffee quantity. After that you should take the milk quantity, decrease it by 5 and insert it back to the sequence. 
Coffee drink	Quantities needed
Cortado	50
Espresso	75
Capuccino	100
Americano	150
Latte	200
Try creating as much drinks as possible while keeping track of the count of different types of coffee beverages that were made. You stop comparing the sum of the coffee and milk in case you are out both of milk and coffee, or in case any one of them is out.
Finally, print the different coffee drinks that Nina managed to make and their count. 
Input
•	On the first line, you will receive the coffee quantities, separated by a comma and a single space (', '). 
•	On the second line, you will receive the milk quantities, separated by a comma and a single space (', ').
Output
•	On the first line – print whether Nina managed to use all of the coffee and milk:
o	If she managed to use all of the coffee and all of the milk: "Nina is going to win! She used all the coffee and milk!"
o	If she didn't manage to use all of the coffee and milk: "Nina needs to exercise more! She didn't use all the coffee and milk!"
•	On the second line – print all of the coffee that you have left:
o	If there is no coffee left: "Coffee left: none"
o	If there is coffee left: "Coffee left: {coffee1}, {coffee2}, {coffee3}, (…)"
•	On the third line – print all of the milk that you have left:
o	If there is no milk left: "Milk left: none"
o	If is milk left: "Milk left: {milk1}, {milk2}, {milk3}, (…)"
•	Then, you need to print the different types of coffee drinks, that were made, and their count. They must be ordered ascending by number and then sorted descending alphabetically.
o	"Latte: {amount}"
o	"Espresso: {amount}"
o	"Cortado: {amount}"
o	"Capuccino: {amount}"
o	"Americano: {amount}"
Constraints
•	All of the given numbers will be valid integers in the range [0…200].
•	There will be no case where the milk quantity reaches 0.
•	Do not use "\r\n" for a new line.
