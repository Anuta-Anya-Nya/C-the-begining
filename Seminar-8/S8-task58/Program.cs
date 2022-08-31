//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int[,] CreateAndPrintMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(1, 4);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    return matrix;
}
void CreateMultiplMatrix(int[,] matr1, int[,] matr2)
{
    int[,] newMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];
    if (matr1.GetLength(1) != matr2.GetLength(0))
    {
        Console.WriteLine("Невозможно вычислить произведение матриц");
        return;
    }
    else
    {
        for (int i = 0; i < newMatr.GetLength(0); i++)
        {
            for (int j = 0; j < newMatr.GetLength(1); j++)
            {
                int result = 0;
                for (int l = 0; l < matr2.GetLength(0); l++)
                {
                    result += matr1[i, l] * matr2[l, j];
                }
                newMatr[i, j] = result;
                Console.Write(newMatr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

int m1 = 2,
    n1 = 3,
    m2 = 3,
    n2 = 2;
int[,] matrix1 = CreateAndPrintMatrix(m1, n1);
Console.WriteLine();
int[,] matrix2 = CreateAndPrintMatrix(m2, n2);
Console.WriteLine("Произведение матриц равно: ");
CreateMultiplMatrix(matrix1, matrix2);