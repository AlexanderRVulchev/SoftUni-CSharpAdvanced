Create a program that helps John to calculate his calories intake, by predefined meals.
You will be given two lines of input. The first line will be an array of strings, separated by a single space, representing meals that John can eat. The second line will be an array of integers, separated by a single space, representing the maximum calories intake per day. 
Here is a table with the exact meals and their calories:
		Meal	Calories
salad	350
soup	490
pasta	680
steak	790
Start calculating calories as follows: take the first meal’s calories and the last element in the sequence of calorie intake for a day. Each time John eats a meal, the calories intake for the current day should be decreased by the calories of the given meal, and the current meal should be removed from the collection. When the calories intake for the given day goes to zero, remove them from the collection, and continue to the next day. If the calories for the given day go below zero, take as many calories as possible from the meal, so the current daily calories intake reaches zero. The rest of the meal’s calories should be subtracted from the next day in the calorie intake sequence.
For more clarification, check the provided examples.
The program stops when there are no more meals to be eaten, or there are no more daily calories to be calculated.
Input
•	On the first line, a sequence of strings will be given representing meals, separated by a single space (" ").
•	On the second line, a sequence of integers will be given, representing the daily calories intake, separated by a single space (" ").
Output
•	As a result, you should print two lines for output:
o	If John menage to eat all the given meals print:
"John had {number of meals} meals."
"For the next few days, he can eat {dailyCalories1, dailyCalories2, etc.} calories."
Separate the daily calories intake by comma and space (", ").
o	If John could not eat every meal:
"John ate enough, he had {number of meals} meals."
"Meals left: {meal1, meal2, etc.}."
Separate the meals by comma and space (", ").
Constraints
•	The daily calories will be in the range [1200…4000].
•	No recursion is needed for solving this problem.
•	The input will be always valid.
•	There will be no case where daily calories and meals go to zero simultaneously.
