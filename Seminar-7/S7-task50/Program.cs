// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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
void FindItem(int[,] matr, int position1, int position2)
{
    if (position1 > matr.GetLength(0) || position1 < 1
            || position2 > matr.GetLength(1) || position2 < 1)
    {
        Console.WriteLine("Элемента с заданной позицией не существует");
    }
    else
    {
        Console.WriteLine($"Элемент с заданной позицией {position1} и {position2} имеет индекс [{position1 - 1}, {position2 - 1}] и равен {matr[position1 - 1, position2 - 1]}.");
    }
}

Console.Write("Введите число m - количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n - количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по горизонтали в массиве: ");
int horiz = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию элемента по вертикали в массиве: ");
int vert = Convert.ToInt32(Console.ReadLine());
FindItem(CreateMatrix(m, n), horiz, vert);
