// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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
int[] arr = FillArrNumb(10, 100, 999);
Console.WriteLine($"[{String.Join(", ", arr)}]");
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine("Количество четных чисел в массиве равно " + count);