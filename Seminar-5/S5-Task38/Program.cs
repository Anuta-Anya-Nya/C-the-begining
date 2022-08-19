//  Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива: ");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"[{String.Join(", ", array)}]");
double min = array[0];
double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Разница между маскимальным значением {max} и минимальным значением {min} равна {max - min}.");
