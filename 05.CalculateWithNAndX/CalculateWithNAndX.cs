using System;
/*
    Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

    Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
    Use only one loop. Print the result with 5 digits after the decimal point.
 */
class CalculateWithNAndX
{
    static void Main()
    {
        Console.Write("Please enter the first integer number - n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer number - x: ");
        int x = int.Parse(Console.ReadLine());
        double sum = 1.0;
        int factorial =1;
        int degree =1;
        for (int i = 1; i <= n; i++)
        {
            factorial *=i;
            degree*=x;
            sum = sum + ((double)factorial / degree);
        }
        Console.WriteLine("The result is: {0:f5}", sum);
    }
}