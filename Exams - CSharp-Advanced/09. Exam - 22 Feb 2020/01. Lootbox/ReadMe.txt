Every purchase gives you two loot boxes and they are represented as a sequence of integers. First, you will be given a sequence of integers, representing the first loot box. Afterwards, you will be given another sequence of integers representing the second loot box. 
You need to start from the first item in the first box and sum it with the last item in the second box. If the sum of their values is an even number, add the summed item to your collection of claimed items and remove them both from the boxes. Otherwise, move the last item from the second box and add it at the last position in the first box. You need to stop summing items when one of the boxes becomes empty.
If the first loot box becomes empty print:
	"First lootbox is empty"
If the second loot box becomes empty print:
	"Second lootbox is empty"
In the end you need to determine the quality of your claimed items. If the sum of the claimed items equal to or greater than 100, print:
	"Your loot was epic! Value: {sum of claimed items}"
Else print:
	"Your loot was poor... Value: {sum of claimed items}"
Input
•	On the first line, you will receive the integers representing the first loot box, separated by a single space. 
•	On the second line, you will receive the integers representing the second loot box, separated by a single space.
Output
•	On the first line of output – print which box got empty in the format described above.
•	On the second line – the quality of your loot in the format described above.
Constraints
•	All of the given numbers will be valid integers in the range [0, 100].
•	There won’t be a case where both loot boxes become empty at the same time.
