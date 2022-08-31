//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void FindBigSum(int[,] anyMatrix)
{
    int[] result = new int[anyMatrix.GetLength(0)];
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        int sumString = 0;
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            sumString += anyMatrix[i, j];
        }
        result[i] = sumString;
    }
    int min = result[0];
    int position = 0;
    for (int i = 1; i < result.Length; i++)
    {
        if (result[i] < min)
        {
            min = result[i];
            position = i;
        }
    }
    Console.WriteLine($"Сумма в {position + 1} строке меньше.");
}
const int m = 3;
const int n = 4;
int[,] matrix = CreateAndPrintMatrix(m, n);
FindBigSum(matrix);