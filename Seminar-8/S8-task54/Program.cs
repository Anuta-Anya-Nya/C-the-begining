//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.
int[,] CreateAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void PrintMatrix(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            Console.Write(anyMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] SortMatrixFromMax(int[,] anyMatrix)
{
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1) - 1; j++)
        {
            int maxElement = anyMatrix[i, j];
            for (int k = j + 1; k < anyMatrix.GetLength(1); k++)
            {
                if (anyMatrix[i, k] > maxElement)
                {
                    anyMatrix[i, j] = anyMatrix[i, k];
                    anyMatrix[i, k] = maxElement;
                    maxElement = anyMatrix[i, j];
                }
            }
        }
    }
    return anyMatrix;
}
const int M = 3;
const int N = 4;
int[,] someNumbers = CreateAndPrintMatrix(M, N);
Console.WriteLine();
SortMatrixFromMax(someNumbers);
PrintMatrix(someNumbers);