Create a program that calculates the ratio between water and flour for predefined bakery products.
You will be given two sequences of real numbers, representing water and flour. 
You should start from the first water and mix it with the last flour. If the ratio of water/flour corresponds to some of the following bakery products:
•	Croissant – consists of 50% water and 50% flour
•	Muffin – consists of 40% water and 60% flour
•	Baguette – consists of 30% water and 70% flour
•	Bagel – consists of 20% water and 80% flour 
Create the corresponding bakery product and remove both the water and the flour from each collection.
If none of the products could be made, you should create the best-selling bakery product which is Croissant. To bake a Croissant, take only so much flour to meet the required ratio of 50% water and 50% flour. The water is removed, and all the excessive flour should be inserted back into the collection. You should stop mixing when you have no more flour or water left.
As a result, you should print two lines for output
•	On the first line print all the products which were baked ordered by amount baked descending, then by name of the products alphabetically. 
•	On the second line print how much water and flour have left.
Input
•	On the first line, you will receive a sequence of real numbers representing the amount of water, separated by a single space (" ").
•	On the second line, you will receive a sequence of real numbers representing the flour, separated by a single space (" ").
Output
•	On the first line print only products which were baked successfully and how many of them, ordered by amount baked descending, then by product name alphabetically:
"{product name}: {amount baked}
 {product name}: {amount baked}
…
"
•	On the second line - print all water you have left:
o	If there is no water: "Water left: None"
o	If there are water left unused: "Water left: { water1}, { water2}, { water3}, (…)"
•	On the third line - print all flour you have left:
o	If there is no flour: "Flour left: None"
o	If there are flour left unused: "Flour left: { flour1}, { flour2}, { flour3}, (…)"
Constraints
•	All numbers will be in rage [1.0…100.0].
•	The input will be always valid.
•	The flour will never go below zero.
