//The Pascal triangle may be constructed in the following manner: In row 0 (the topmost row),
//there is a unique nonzero entry 1.
//Each entry of each subsequent row is constructed by adding the number above
//and to the left with the number above and to the right, treating blank entries as 0.
//For example, the initial number in the first (or any other) row is 1(the sum of 0 and 1),
//whereas the numbers 1 and 3 in the third row are added to produce the number 4 in the fourth row.
//Print each row element separated with whitespace.

using System;


internal class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        long[][] triangle = new long[size][];
        triangle[0] = new long[1] { 1 };
        for (int row = 1; row < size; row++)
        {
            triangle[row] = new long[row + 1];
            triangle[row][0] = 1;
            for (int col = 1; col < row; col++)
            {
                triangle[row][col] = triangle[row - 1][col - 1] + triangle[row - 1][col];
            }
            triangle[row][row] = 1;
        }

        for (int row = 0; row < triangle.Length; row++)
        {
            for (int col = 0; col < triangle[row].Length; col++)
            {
                Console.Write(triangle[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}