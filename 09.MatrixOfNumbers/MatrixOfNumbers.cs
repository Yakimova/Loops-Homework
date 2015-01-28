using System;
/*
    Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */
class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please enter n (1<=n<=20): ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write((i + j - 1) + " ");
            }
            Console.WriteLine();
        }

    }
}
