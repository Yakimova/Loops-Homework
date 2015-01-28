using System;
/*
    Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
 */
class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number n: ");
        int n = int.Parse(Console.ReadLine());
        int max = Int32.MinValue;
        int min = Int32.MaxValue;
        double sum = 0;
        double average = 0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number > max)
            {
                max = number;
            }
            if (number < min)
            {
                min = number;
            }
            sum += number;
        }
        average = (sum) / n;

        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:F2}", average);
    }
}