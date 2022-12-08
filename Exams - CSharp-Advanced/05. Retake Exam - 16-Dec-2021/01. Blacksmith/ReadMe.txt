First, you will be given a sequence representing steel. Afterward, you will be given another sequence representing carbon.
You should start from the first steel and try to mix it with the last carbon. If the sum of their values is equal to any of the swords in the table below you should forge the sword corresponding to the value and remove both the steel and the carbon. Otherwise, remove only the steel, increase the value of the carbon by 5 and insert it back into the collection. You need to stop forging when you have no more steel or carbon left.
Sword	Resources needed
Gladius	70
Shamshir	80
Katana	90
Sabre	110
Broadsword	150

Forge as many swords as possible.
Input
•	On the first line, you will receive the steel, separated by a single space (" "). 
•	On the second line, you will receive the carbon, separated by a single space (" ").
Output
•	On the first line of output depending on the result:
o	If at least one sword was forged: "You have forged {totalNumberOfSwords} swords."
o	If no sword was forged: "You did not have enough resources to forge a sword."
•	On the second line - print all steel you have left:
o	If there are no steel: "Steel left: none"
o	If there are steel: "Steel left: {steel1}, {steel2}, {steel3}, (…)"
•	On the third line - print all carbon you have left:
o	If there are no carbon: "Carbon left: none"
o	If there are carbon: "Carbon left: {carbon1}, {carbon2}, {carbon3}, (…)"
•	Then, you need to print only the swords that you manage to forge and how many of them, ordered alphabetically:
o	"Broadsword: {amount}"
o	"Sabre: {amount}"
o	"Katana: {amount}"
o	"Shamshir: {amount}"
o	"Gladius: {amount}"
Constraints
•	All of the given numbers will be valid resources in the range [0, 130].
