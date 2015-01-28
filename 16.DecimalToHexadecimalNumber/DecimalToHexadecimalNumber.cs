using System;
/*
    Problem 16. Decimal to Hexadecimal Number

    Using loops write a program that converts an integer number to its hexadecimal representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */
class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long input = long.Parse(Console.ReadLine());
        long decimalNumber = input;
        string hexadecimal = "";

        //type long - 2^64 = 16^8
        for (int i = 8; i >= 0; i--)
        {
            long degreeof16 = 1;
            for (int j = 1; j <= i; j++)
            {
                degreeof16 *= 16;
            }
            long devisor = (decimalNumber / degreeof16);
            switch (devisor)
            {
                case 1:
                    hexadecimal += 1;
                    decimalNumber = decimalNumber - (degreeof16 * 1);
                    break;
                case 2: 
                    hexadecimal += 2;
                    decimalNumber = decimalNumber - (degreeof16 * 2);
                    break;
                case 3:
                    hexadecimal += 3;
                    decimalNumber = decimalNumber - (degreeof16 * 3);
                    break;
                case 4:
                    hexadecimal += 4;
                    decimalNumber = decimalNumber - (degreeof16 * 4);
                    break;
                case 5:
                    hexadecimal += 5;
                    decimalNumber = decimalNumber - (degreeof16 * 5);
                    break;
                case 6:
                    hexadecimal += 6;
                    decimalNumber = decimalNumber - (degreeof16 * 6);
                    break;
                case 7:
                    hexadecimal += 7;
                    decimalNumber = decimalNumber - (degreeof16 * 7);
                    break;
                case 8:
                    hexadecimal += 8;
                    decimalNumber = decimalNumber - (degreeof16 * 8);
                    break;
                case 9:
                    hexadecimal += 9;
                    decimalNumber = decimalNumber - (degreeof16 * 9);
                    break;
                case 10:
                    hexadecimal += "A";
                    decimalNumber = decimalNumber - (degreeof16 * 10);
                    break;
                case 11:
                    hexadecimal += "B";
                    decimalNumber = decimalNumber - (degreeof16 * 11);
                    break;
                case 12:
                    hexadecimal += "C";
                    decimalNumber = decimalNumber - (degreeof16 * 12);
                    break;
                case 13:
                    hexadecimal += "D";
                    decimalNumber = decimalNumber - (degreeof16 * 13);
                    break;
                case 14:
                    hexadecimal += "E";
                    decimalNumber = decimalNumber - (degreeof16 * 14);
                    break;
                case 15:
                    hexadecimal += "F";
                    decimalNumber = decimalNumber - (degreeof16 * 15);
                    break;
                default:
                    hexadecimal += 0;
                    break;
            }
        }

        // not to print the zeros in the begining
        if (input == 0)
        {
            Console.WriteLine("The hexadecimal representation of this number is: 0");
        }
        else
        {
            int br = 0;
            while (hexadecimal[br] == '0')
            {
                br++;
            }
            Console.Write("The hexadecimal representation of this number is: ");
            for (int i = br; i < hexadecimal.Length; i++)
            {
                Console.Write(hexadecimal[i]);
            }
            Console.WriteLine();
        }
    }
}
