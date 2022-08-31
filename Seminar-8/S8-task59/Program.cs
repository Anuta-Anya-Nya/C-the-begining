//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива.
int[,] CreateAndPrintMatrix(int m, int n) //Создает и печатает матрицу
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
void PrintMatrix(int[,] anyMatrix) //распечатывает матрицу
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
void FindIndexOfMinElement(int[,] anyMatrix, out int indexRow, out int indexCol) // находит координаты наименьшего элемента массива
{
    int min = anyMatrix[0, 0];
    indexCol = -1;
    indexRow = -1;
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            if (anyMatrix[i, j] < min)
            {
                min = anyMatrix[i, j];
                indexRow = i;
                indexCol = j;
            }
        }
    }
    Console.WriteLine("Минимум: " + min);
    Console.WriteLine("Индекс строки: " + indexRow);
    Console.WriteLine("Индекс колонки: " + indexCol);
}
int[,] CreateAnotherMatrix(int[,] anyMatrix, int indexRow, int indexCol) //Создает новую матрицу 
{
    int[,] newMatrix = new int[anyMatrix.GetLength(0) - 1, anyMatrix.GetLength(1) - 1];
    for (int i = 0; i < anyMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < anyMatrix.GetLength(1); j++)
        {
            if (i - indexRow > 0 && j - indexCol > 0)
            {
                newMatrix[i - 1, j - 1] = anyMatrix[i, j];
            }
            else if (i - indexRow > 0 && j - indexCol < 0)
            {
                newMatrix[i - 1, j] = anyMatrix[i, j];
            }
            else if (i - indexRow < 0 && j - indexCol > 0)
            {
                newMatrix[i, j - 1] = anyMatrix[i, j];
            }
            else if (i - indexRow < 0 && j - indexCol < 0)
            {
                newMatrix[i, j] = anyMatrix[i, j];
            }
        }
    }
    return newMatrix;
}

Console.Write("Введите число m - количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int index1;
int index2;
int[,] matrix = CreateAndPrintMatrix(m, n);
FindIndexOfMinElement(matrix, out index1, out index2);
Console.WriteLine();
PrintMatrix(CreateAnotherMatrix(matrix, index1, index2));