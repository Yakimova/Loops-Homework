using System;
/*
    Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */
class BinarytoDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter binary integer number: ");
        string binary = Console.ReadLine();
        long number = 0L;
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                int currentdegree = 1;
                for (int j = 1; j <= (binary.Length - 1 - i); j++)
                {
                    currentdegree *= 2;
                }
                number += currentdegree;
            }
        }
        Console.WriteLine("Decimal representation is: " + number);
    }
}
