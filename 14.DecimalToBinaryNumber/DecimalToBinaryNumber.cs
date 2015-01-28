using System;
/*
    Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */
class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        long input = long.Parse(Console.ReadLine());
        long decimalNumber = input;
        string binary = "";

        // type long can have value of maximum 2^64
        for (int i = 63; i >=0; i--)
        {
            long degreeof2 = 1;
            for (int j = 1; j <= i; j++)
            {
                degreeof2 *= 2;
            }
            if (decimalNumber / degreeof2 == 1)
            {
                binary += "1";
                decimalNumber = decimalNumber - (degreeof2 * 1);
            }
            else
            {
                binary += "0";
            }
        }


        // not to print the zeros in the begining
        if (input == 0)
        {
            Console.WriteLine("The binary representation of this number is: 0");
        }
        else
        {
            int br = 0;
            while (binary[br]=='0')
            {
                br++;
            }
            Console.Write("The binary representation of this number is: ");
            for (int i=br; i<binary.Length; i++)
            {
                Console.Write(binary[i]);
            }
            Console.WriteLine();
        }
    }
}