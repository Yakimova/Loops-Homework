using System;
/*
    Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */
class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] separateNumbers = input.Split(' ');
        int[] clearNumbers = new int[separateNumbers.Length];
        for (int i = 0; i < separateNumbers.Length; i++)
        {
            clearNumbers[i] = int.Parse(separateNumbers[i]);
        }
        int oddProduct = 1;
        int evenProduct = 1;
        for (int i = 0; i < clearNumbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= clearNumbers[i];
            }
            else
            {
                oddProduct *= clearNumbers[i];
            }
        }
        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
