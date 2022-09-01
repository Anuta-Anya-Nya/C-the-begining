// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int[] FillArrNumb(int leng, int numMin, int numMax)
{
    while (leng <= 0)
    {
        Console.WriteLine("Введено неверное значение! Введите другое: ");
        leng = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        array[i] = new Random().Next(numMin, numMax + 1);
    }
    return array;
}
int[] arr = FillArrNumb(123, -100, 100);
Console.WriteLine($"[{String.Join(", ", arr)}]");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] >= 10 && arr[i] <= 99)
    {
        count++;
    }
}
Console.WriteLine(count);

// int[] array = new int[100];
// int count = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     Console.Write(array[i] + ",");
// }
// Console.WriteLine();
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j] > 9 & array[j] < 100) count = count + 1;
// }
// Console.WriteLine();
// Console.Write($"на отрезке [10,99] содержится - {count} элементов");