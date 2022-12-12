First, you will be given a sequence of integers, representing liquids. Afterwards, you will be given another sequence of integers representing ingredients.
You need to start from the first liquid and try to mix it with the last ingredient. If the sum of their values is equal to any of the items in the table below – cook the food corresponding to the value and remove both the liquid and the ingredient. Otherwise, remove only the liquid and increase the value of the ingredient by 3. You need to stop cooking when you have no more liquids or ingredients.
Food	Value needed
Bread	25
Cake	50
Pastry	75
Fruit Pie	100

In order to cook enough food for the bakery, you need one of each of the foods. 
Input
•	On the first line, you will receive the integers representing the liquids, separated by a single space. 
•	On the second line, you will receive the integers representing the ingredients, separated by a single space.
Output
•	On the first line of output – print if you succeeded in cooking everything:
o	"Wohoo! You succeeded in cooking all the food!"
o	"Ugh, what a pity! You didn't have enough materials to cook everything."
•	On the second line - print all liquids you have left:
o	If there are no liquids: "Liquids left: none"
o	If there are liquids: "Liquids left: {liquid1}, {liquid2}, {liquid3}, (…)"
•	On the third line - print all ingredients you have left:
o	If there are no items: "Ingredients left: none"
o	If there are items: "Ingredients left: {ingredient}, {ingredient}, {ingredient}, (…)"
•	Then, you need to print all products you have cooked and the amount you have of them, ordered alphabetically:
o	"Bread: {amount}"
o	"Cake: {amount}"
o	"Fruit Pie: {amount}"
o	"Pastry: {amount}"
Constraints
•	All of the given numbers will be valid integers in the range [0, 100].
