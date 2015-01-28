using System;
/*
    Problem 12.* Randomize the Numbers 1…N

    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 */

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.Write("Please enter an integer n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Random randomNumbers = new Random();
        for (int i = 1; i <= n; i++)
        {
            int possition = randomNumbers.Next(0, n);
            while (numbers[possition] == 0)
            {
                possition = randomNumbers.Next(0, n );
            }
            Console.Write(numbers[possition] + " ");
            numbers[possition] = 0;
        }
        Console.WriteLine();
    }
}
