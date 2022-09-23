//Create a program that executes some mathematical operations on a given collection.
//On the first line, you are given a list of numbers.
//On the next lines you are passed different commands
//that you need to apply to all the numbers in the list:
//•	"add"->add 1 to each number
//•	"multiply" -> multiply each number by 2
//•	"subtract" -> subtract 1 from each number
//•	"print" -> print the collection
//•	"end" -> ends the input 
//Note: Use functions.


using System;
using System.Linq;

class Program
{
    // Function definitions:
    static Func<int[], int[]> add =
        arr => arr.Select(x => ++x).ToArray();
    static Func<int[], int[]> multiply =
        arr => arr.Select(x => x * 2).ToArray();
    static Func<int[], int[]> subtract =
        arr => arr.Select(x => --x).ToArray();
    static Action<int[]> print =
        arr => Console.WriteLine(String.Join(" ", arr));

    static void Main()
    {        
        int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();        
        InputLoopByRecursion(Console.ReadLine(), nums);
    }

    static void InputLoopByRecursion(string input, int[] nums)
    {
        switch (input)
        {
            case "add": nums = add(nums); break;
            case "multiply": nums = multiply(nums); break;
            case "subtract": nums = subtract(nums); break;
            case "print": print(nums); break;
            case "end": return;
        }
        InputLoopByRecursion(Console.ReadLine(), nums);
    }
}