// Carter Glynn
// PROG2325 User Interface
// Assignment 1 - Martix Multiplier
// Created 2022 - 09 - 16

using Microsoft.VisualBasic.FileIO;
using System;
using System.Globalization;

class Glynn_Assignment1
{
    public static int Main()
    {
        Console.WriteLine("\nWelcome To the Matrix Multiplier!\nPlease select an option by typing either:");
        Console.WriteLine("\t1. Matricies Multiplication\n\t2. Exit Program");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 1)
        {
            MultiplyMenu();
        }
        else if (option == 2)
        {
            Console.WriteLine("\nThanks for playing!\n");
            return 0;
        }
        Console.WriteLine("Invalid key entry, please try again.");
        Main();
        return 0;

    }
    public static void MultiplyMenu()
    {
        Console.Write("\nEnter the dimension of the two matricies or 'b' to go back to the previous menu: ");
        string option = Console.ReadLine();
        if ((option == "b") || (option == "B"))
        {
            Main();
        }
        try
        {
            int dimension = Convert.ToInt32(option);
            MatrixInit(dimension);

        }
        catch (OverflowException)
        {
            Console.WriteLine("\n" + "*************************************************" +
                                   "\n{0} is either too large or too small of a number!" +
                                   "\n*************************************************", option);
            MultiplyMenu();
        }
        catch (FormatException)
        {
            Console.WriteLine("\n" + "**********************************************************" +
                                   "\nThe {0} '{1}' does not work, please enter ONLY the number." +
                                   "\n**********************************************************", option.GetType().Name, option);
            MultiplyMenu();
        }
    }
    public static void MatrixInit(int dimension)
    {
        int[,] matrix1 = new int[dimension, dimension];
        int[,] matrix2 = new int[dimension, dimension];
        Console.WriteLine("\nThe matricies should look like this example? Enter y for yes and n for no");
        ExampleMatrix(dimension);
        string input = Console.ReadLine();
        if ((input == "y") || (input == "Y"))
        {
            Console.WriteLine("\nPlease enter matrix values one by one:");
            Console.WriteLine("Entering numbers for matrix 1");
            MatrixEntry(matrix1, dimension);
            Console.WriteLine("Entering numbers for matrix 2");
            MatrixEntry(matrix2, dimension);
            MatrixMultiply(matrix1, matrix2, dimension);
            Main();
        }
        else if ((input == "n") || (input == "N"))
        {
            Console.WriteLine("\nPlease enter dimension of the square matrix.");
            MultiplyMenu();
        }
        else
        {
            Console.WriteLine("\nInvalid input.");
            MultiplyMenu();
        }
    }
    public static void ExampleMatrix(int dimension)
    {
        int asciiValue = 65;
        for (int j = 0; j < 2; j++)
        {
            Console.Write("\n\t\t");
            Console.WriteLine("\nMatrix {0}", j + 1);
            for (int i = 0; i < dimension; i++)
            {
                Console.Write("\n\n\t");
                for (int k = 0; k < dimension; k++)
                {
                    Console.Write("[ {0} ]\t", Convert.ToChar(asciiValue));
                    asciiValue++;
                }
            }
            Console.Write("\n");
        }
    }
    public static void MatrixMultiply(int[,] matrix1, int[,] matrix2, int dimension)
    {
        int temp = 0;
        int[,] result = new int[dimension, dimension];

        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                temp = 0;
                for (int k = 0; k < dimension; k++)
                {
                    temp += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = temp;
            }
        }
        Console.WriteLine("Matrix 1:\n");
        PrintMatrix(matrix1, dimension);
        Console.WriteLine("\n\n\t\t+\t\t\n");
        Console.WriteLine("Matrix 2:\n");
        PrintMatrix(matrix2, dimension);
        Console.WriteLine("\n\n\t\t=\t\t\n");
        Console.WriteLine("Resulting Matrix:\n");
        PrintMatrix(result, dimension);
    }
    public static void PrintMatrix(int[,] matrix, int dimension)
    {
        for (int i = 0; i < dimension; i++)
        {
            for (int j = 0; j < dimension; j++)
            {
                Console.Write("\t[ {0} ]", matrix[i, j]);
            }
            Console.WriteLine("\n");
        }
    }
    public static void MatrixEntry(int[,] matrix, int dimension)
    {
        for (int k = 0; k < dimension; k++)
        {
            for (int j = 0; j < dimension; j++)
            {
                try
                {
                    Console.Write("Matrix\tRow {0} Column {1}:\t", k + 1, j + 1);
                    matrix[k, j] = Convert.ToInt32(Console.ReadLine());

                }
                catch (OverflowException)
                {
                    Console.WriteLine("\n" + "*************************************************" +
                                           "\n{0} is either too large or too small of a number!" +
                                           "\n*************************************************", matrix[k, j]);
                    MatrixEntry(matrix, dimension);
                }  
                catch (FormatException)
                {
                    Console.WriteLine("\n" + "**********************************************************************" +
                                           "\nThe {0} '{1}' does not work, please try again (enter ONLY the number)." +
                                           "\n**********************************************************************", matrix[k, j].GetType().Name, matrix[k, j]);
                    MatrixEntry(matrix, dimension);
                }
            }
        }
        PrintMatrix(matrix, dimension);
    }
}
   
