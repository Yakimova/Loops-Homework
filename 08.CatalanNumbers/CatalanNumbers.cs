using System;
using System.Numerics;
/*
    Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
 */
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Please enter the integer number - n: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 0)
        {
            Console.Write("n>=0. Please enter n: ");
            n = int.Parse(Console.ReadLine());
        }
        BigInteger upfactorial = 1;
        for (int i = (n + 1); i <= (2 * n); i++)
        {
            upfactorial *= i;
        }
        BigInteger downfactorial = 1;
        for (int i = 1; i <= (n + 1); i++)
        {
            downfactorial *= i;
        }
        Console.WriteLine("Result: " + (upfactorial / downfactorial));

    }
}
