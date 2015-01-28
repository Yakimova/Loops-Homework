using System;
/*
    Problem 17.* Calculate GCD

    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
    Use the Euclidean algorithm (find it in Internet).
 */
class CalculateGCD
{
    static void Main()
    {
        Console.Write("Please enter the first integer - a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Please enter the second integer - b: ");
        int b = int.Parse(Console.ReadLine());
        int absa = a;
        int absb = b;

        // negative divisors will always be smaller than 1
        if (a < 0)
        {
            absa = -a;
        }
        if (b < 0)
        {
            absb = -b;
        }

        //using the Euclidean algorithm
        int smallerNumber;
        int biggerNumber;
        if (absa >= absb)
        {
            smallerNumber = absb;
            biggerNumber = absa;
        }
        else
        {
            smallerNumber = absa;
            biggerNumber = absb;
        }
        do
        {
            int c = biggerNumber - smallerNumber;
            if (c >= smallerNumber)
            {
                biggerNumber = c;
            }
            else
            {
                biggerNumber = smallerNumber;
                smallerNumber = c;
            }
        } while (smallerNumber != 0);

        Console.WriteLine("GCD({0}, {1}) = {2}", a, b, biggerNumber);
    }
}
