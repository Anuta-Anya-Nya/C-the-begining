// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int m, int n)
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

void CountAverage(int[,] matr)
{
    double average = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            average += matr[j, i];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i + 1} равно {average / matr.GetLength(0)}.");
        average = 0;
    }
}

Console.Write("Введите число m - количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

CountAverage(CreateMatrix(m, n));

