using System;
/*
    Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Please enter an integer number n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter an integer number min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please enter an integer number max (max>min): ");
        int max = int.Parse(Console.ReadLine());
        while (max <= min)
        {
            Console.Write("Max>min. Please enter max: ");
            max = int.Parse(Console.ReadLine());
        }

        Random randomNumbers = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write(randomNumbers.Next(min, (max+1)) + " ");
        }
        Console.WriteLine();
    }
}
