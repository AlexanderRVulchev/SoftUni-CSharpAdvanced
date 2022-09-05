//Our favorite super-spy action hero Sam is back from his mission in another exam,
//and this time he has an even more difficult task. He needs to unlock a safe.
//The problem is that the safe is locked by several locks in a row, which all have varying sizes.
//Our hero possesses a special weapon though, called the Key Revolver, with special bullets.
//Each bullet can unlock a lock with a size equal to or larger than the size of the bullet.
//The bullet goes into the keyhole, then explodes, destroying it.
//Sam doesn’t know the size of the locks, so he needs to just shoot at all of them until the safe run out of locks.
//What’s behind the safe, you ask? Well, intelligence! It is told that Sam’s sworn enemy – Nikoladze,
//keeps his top-secret Georgian Chacha Brandy recipe inside.
//It’s valued differently across different times of the year,
//so Sam’s boss will tell him what it’s worth over the radio.
//One last thing, every bullet Sam fires will also cost him money,
//which will be deducted from his pay from the price of the intelligence. 
//Good luck, operative.
//Input
//•	On the first line of input, you will receive the price of each bullet – an integer in the range [0-100]
//•	On the second line, you will receive the size of the gun barrel – an integer in the range [1-5000]
//•	On the third line, you will receive the bullets – a space-separated integer sequence with [1-100] integers
//•	On the fourth line, you will receive the locks – a space-separated integer sequence with [1-100] integers
//•	On the fifth line, you will receive the value of the intelligence – an integer in the range [1-100000]
//After Sam receives all of his information and gear (input),
//he starts to shoot the locks front-to-back, while going through the bullets back-to-front.
//If the bullet has a smaller or equal size to the current lock, print "Bang!", then remove the lock.
//If not, print "Ping!", leaving the lock intact. The bullet is removed in both cases.
//If Sam runs out of bullets in his barrel, print "Reloading!" on the console, then continue shooting.
//If there aren’t any bullets left, don’t print it.
//The program ends when Sam either runs out of bullets, or the safe runs out of locks.
//Output
//•	 If Sam runs out of bullets before the safe runs out of locks, print:
//"Couldn't get through. Locks left: {locksLeft}"
//•	If Sam manages to open the safe, print:
//"{bulletsLeft} bullets left. Earned ${moneyEarned}"
//Make sure to account for the price of the bullets when calculating the money earned.


using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static Stack<int> bullets = new Stack<int>();
    static Queue<int> locks = new Queue<int>();
    static Queue<int> barrel = new Queue<int>();
    static int barrelSize = 0;

    static void Main()
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        barrelSize = int.Parse(Console.ReadLine());
        LoadInitialBulletsAndLocks();
        Reload();        
        int moneyEarned = int.Parse(Console.ReadLine());

        while (barrel.Count > 0 && locks.Count > 0)
        {
            moneyEarned -= bulletPrice;
            int bulletShot = barrel.Dequeue();
            if (bulletShot <= locks.Peek())
            {
                Console.WriteLine("Bang!");
                locks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }

            if (barrel.Count == 0 && bullets.Count > 0)
            {
                Console.WriteLine("Reloading!");
                Reload();
            }
        }

        if (locks.Count == 0)
            Console.WriteLine($"{bullets.Count + barrel.Count} bullets left. Earned ${moneyEarned}");
        else
            Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
    }

    private static void LoadInitialBulletsAndLocks()
    {
        int[] bulletsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        foreach (int bullet in bulletsInput)
            bullets.Push(bullet);

        int[] locksInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
        foreach (int singleLock in locksInput)
            locks.Enqueue(singleLock);
    }

    private static void Reload()
    {
        for (int i = 0; i < barrelSize; i++)
        {
            if (bullets.Count > 0)
                barrel.Enqueue(bullets.Pop());
        }
    }
}