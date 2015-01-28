using System;
using System.Numerics;
/*
    Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */
class CalculateNKN
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
        int difference = n - k;
        BigInteger nfactorial = 1;
        BigInteger kfactorial = 1;
        BigInteger nkfactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nfactorial *= i;
            if (difference >= i)
            {
                nkfactorial *= i;
            }
        }
        for (int i = 1; i <= k; i++)
        {
            kfactorial *= i;
        }
        BigInteger result = nfactorial / (kfactorial * nkfactorial);
        Console.WriteLine("The result is: {0}", result);

    }
}
