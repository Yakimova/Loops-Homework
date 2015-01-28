using System;
using System.Numerics;
/*
    Problem 18.* Trailing Zeroes in N!

    Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
    Your program should work well for very big numbers, e.g. n=100000.
 */
class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("Please eneter integer number n: ");
        int n = int.Parse(Console.ReadLine());
        int counter5=0;
        
        //the number of zeros in the end means multiplication by 10 = 5*2, from this two prime numbers 5 is more rare, so we need to count how many times we multiplicate by 5
        for (int i = 5; i <= n; i+=5)
        {
            int multiplication = i;
            while (multiplication % 5 == 0)
            {
                counter5++;
                multiplication = multiplication / 5;
            }
        }
        
        Console.WriteLine("The number of trailing zeros of {0}! is {1}", n, counter5);
    }
}
