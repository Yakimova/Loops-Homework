using System;
/*
    Problem 15. Hexadecimal to Decimal Number

    Using loops write a program that converts a hexadecimal integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */
class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter hexadecimal integer number: ");
        string hexadecimal = Console.ReadLine();
        long number = 0L;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            int currentdegree = 1;
            switch (hexadecimal[i])
            {
                case '1':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (1*currentdegree);
                    break;
                case '2':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (2 * currentdegree);
                    break;
                case '3':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (3 * currentdegree);
                    break;
                case '4':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (4 * currentdegree);
                    break;
                case '5':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (5 * currentdegree);
                    break;
                case '6':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (6 * currentdegree);
                    break;
                case '7':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (7 * currentdegree);
                    break;
                case '8':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (8 * currentdegree);
                    break;
                case '9':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (9 * currentdegree);
                    break;
                case 'A':
                case 'a':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (10 * currentdegree);
                    break;
                case 'B':
                case 'b':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (11 * currentdegree);
                    break;
                case 'C':
                case 'c':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (12 * currentdegree);
                    break;
                case 'D':
                case 'd':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (13 * currentdegree);
                    break;
                case 'E':
                case 'e':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (14 * currentdegree);
                    break;
                case 'F':
                case 'f':
                    for (int j = 1; j <= (hexadecimal.Length - 1 - i); j++)
                    {
                        currentdegree *= 16;
                    }
                    number = number + (15 * currentdegree);
                    break;
                default:
                    break;

            }
        }
        Console.WriteLine("decimal representation is: " + number);
    }
}