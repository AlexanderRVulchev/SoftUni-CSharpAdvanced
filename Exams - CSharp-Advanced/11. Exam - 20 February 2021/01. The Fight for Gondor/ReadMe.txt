First, you will be given a number equal to the waves of orcs. On the second line you will be given the plates of the Aragorn's defense. Then, on each next line (for each wave), you receive the power of each orc  warrior. Additionally, on every third wave, the people build a new plate (extra line with a single integer) before the Sauron's warriors attack. In order to enter the city, the orcs have to destroy all the plates.
Until there are no more plates or orcs, the last orc warrior attacks the first plate:
•	If the warrior's value is greater, he destroys the plate and lowers his value by the plate's value, then attacks the next plate, until his value reaches 0.
•	If the plate's value is greater, the warrior dies and the plate decreases its value by the warrior's value.
•	If their values are equal, the warrior dies and the plate is destroyed.
Input
•	First line: integer- the number of waves
•	Second line: integers, representing the plates, separated by a single space.
•	For each wave: integers, representing the warrior orcs, separated by a single space.
o	On every third wave, you will be given an extra line with a single integer, which will be the plate you need to add. [!] Add the plate before processing the attacks. [!]
Output
•	On the first line of output – print if the orcs destroyed the Gondor's defense:
o	True: "The orcs successfully destroyed the Gondor's defense."
o	False: "The people successfully repulsed the orc's attack."
•	On the second line - print all plates or orcs left, separated by comma and a white space:
o	If there are warriors: "Orcs left: {orc1}, {orc2}, {orc3}, …"
o	If there are plates: "Plates left: {plate1}, {plate2}, {plate3}, …"
Constraints
•	All of the given numbers will be valid integers in the range [1, 100].
•	Not all waves may be needed to destroy the defense.
•	There will always be a winning side, meaning either no orcs or plates left. 
