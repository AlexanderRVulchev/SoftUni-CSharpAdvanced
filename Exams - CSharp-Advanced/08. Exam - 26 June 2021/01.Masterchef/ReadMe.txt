First you will receive a sequence of integers, representing the number of ingredients in a single basket. After that you will be given another sequence of integers - the freshness level of the ingredients.
Your task is to cook them so you can impress the judges. The names of the dishes are listed in the table below with the exact freshness level. 

Dish	Freshness Level needed
Dipping sauce	150
Green salad	250
Chocolate cake	300
Lobster	400
 
To cook a dish, you have to take the first ingredient value and the last freshness level value. The total freshness level is calculated by their multiplication.
•	If the product of this operation equals one of the levels described in the table, you make the dish and remove both ingredient and freshness value. 
•	Otherwise you should remove the freshness level, then increase the ingredient value by 5
o	Remove the ingredient from the collection and add it again in last place, already increased by 5. 
•	In case you have an ingredient with value 0 you have to remove it and continue cooking.
You need to stop cooking only when you run out of ingredients or freshness level values.
Your task is considered successful if you make at least four dishes - one of each type.
1.	Input
•	The first line of input will represent the ingredients' values - integers, separated by single space
•	On the second line you will be given the freshness values - integers again, separated by single space
2.	Output
•	On the first line of output - print if you've succeeded in preparing the dishes
o	"Applause! The judges are fascinated by your dishes!"
o	"You were voted off. Better luck next year."
•	On the next output line - print the sum of the ingredients only if they are left any in the format: " Ingredients left: {ingridientsSum}"
•	On the last few lines you have to print the dishes you have made ordered alphabetically, but only the ones that were made at least once in the format:
" # {dish name} --> {amount}"
3.	Constraints
•	All of the ingredients' values and freshness level values will be integers in range [0, 100]
•	We can have more than one cooked dish of the types specified in the table above
