On the first line you will be given some tasks as integer values, separated by comma and space ", ". On the second line you will be given some threads as integer values, separated by a single space. On the third line, you will receive the integer value of a task that you need to kill. Your job is to stop the work of the CPU as soon as you get to this task, otherwise your CPU will crash. The thread that gets first to this task, kills it.
The CPU works in the following way:
•	It takes the first given thread value and the last given task value.
•	If the thread value is greater than or equal to the task value, the task and thread get removed.
•	If the thread value is less than the task value, the thread gets removed, but the task remains.
After you finish the needed task, print on a single line:
"Thread with value {thread} killed task {taskToBeKilled}"
Then print the remaining threads (including the one that killed the task) starting from the first on a single line, separated by a single space.
Input
•	On the first line you will receive the tasks, separated by ", ".
•	On the second line you will the threads, separated by a single space.
•	On the third line, you will receive a single integer – value of the task to be killed.
Output
•	Print the thread that killed the task and task itself in the format given above.
•	Print the remaining threads starting from the first on a single line, separated by a single space.
Constraints
•	The needed task will always be with a unique value
•	You will always have enough threads to get to the needed task
