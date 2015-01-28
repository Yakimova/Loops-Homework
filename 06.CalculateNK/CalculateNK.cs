using System;
using System.Numerics;
/*
    Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
 */
class CalculateNK
{
    static void Main()
    {
        Console.Write("Please enter the first integer number - n: ");
        int n = int.Parse(Console.ReadLine());
        int k = n;
        while (k >= n)
        {
            Console.Write("k must be smaler than n. Please enter k:  ");
            k = int.Parse(Console.ReadLine());
        }

        BigInteger result = 1;
        for (BigInteger i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine("n!/k! = {0}", result);
    }
}
