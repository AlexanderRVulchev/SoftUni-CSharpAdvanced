You will be given a two sequence of integers, representing bomb effects and bomb casings.
You need to start from the first bomb effect and try to mix it with the last bomb casing. If the sum of their values is equal to any of the materials in the table below – create the bomb corresponding to the value and remove the both bomb materials. Otherwise, just decrease the value of the bomb casing by 5. You need to stop combining when you have no more bomb effects or bomb casings, or you successfully filled the bomb pouch.
Bombs:
•	Datura Bombs: 40
•	Cherry Bombs: 60
•	Smoke Decoy Bombs: 120
To fill the bomb pouch, Ezio needs three of each of the bomb types.
Input
•	On the first line, you will receive the integers representing the bomb effects, separated by ", ".
•	On the second line, you will receive the integers representing the bomb casing, separated by ", ".
Output
•	On the first line of output – print one of these rows according whether Ezio succeeded fulfill the bomb pouch:
o	"Bene! You have successfully filled the bomb pouch!"
o	"You don't have enough materials to fill the bomb pouch."
•	On the second line - print all bomb effects left:
o	If there are no bomb effects: "Bomb Effects: empty"
o	If there are effects: "Bomb Effects: {bombEffect1}, {bombEffect2}, (…)"
•	On the third line - print all bomb casings left:
o	If there are no bomb casings: "Bomb Casings: empty"
o	If there are casings: "Bomb Casings: {bombCasing1}, {bombCasing2}, (…)"
•	Then, you need to print all created bombs and the count you have of them, ordered alphabetically:
o	"Cherry Bombs: {count}"
o	"Datura Bombs: {count}"
o	"Smoke Decoy Bombs: {count}"
Constraints
•	All of the given numbers will be valid integers in the range [0, 120].
•	Don't have situation with negative material.
