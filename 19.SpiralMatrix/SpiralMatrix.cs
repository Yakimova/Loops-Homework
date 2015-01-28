using System;
/*
    Problem 19.** Spiral Matrix

    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
 */
class SpiralMatrix
{
    static void PrintOnPossition(int x, int y, int number)
    {
        Console.SetCursorPosition(x, y);
        Console.Write(number);
    }
    static void Main()
    {
        Console.Write("Please enter a possitive integer number n (1<=n<=20): ");
        int n = int.Parse(Console.ReadLine());
        int [,]matrix = new int[n,n];
        int number =1;

        for (int i = 0; i < n; i++)
        {
            for (int col = i; col < (n-i); col++)
            {
                if (matrix[i, col] == 0)
                {
                    matrix[i, col] = number;
                    number++;
                }
            }
            for (int row = (i+1); row < (n-i); row++)
            {
                if (matrix[row, (n - 1 - i)] == 0)
                {
                    matrix[row, (n - 1 - i)] = number;
                    number++;
                }
            }
            for (int col = (n - 2-i); col >= i; col--)
            {
                if (matrix[n - 1 - i, col] == 0)
                {
                    matrix[n - 1 - i, col] = number;
                    number++;
                }
            }
            for (int row = (n - 2-i); row >= (i+1); row--)
            {
                if (matrix[row, i] == 0)
                {
                    matrix[row, i] = number;
                    number++;
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i, j] < 10)
                {
                    Console.Write(matrix[i, j] + "   ");
                }
                else if (matrix[i, j] < 100)
                {
                    Console.Write(matrix[i, j] + "  ");
                }
                else
                {
                    Console.Write(matrix[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
