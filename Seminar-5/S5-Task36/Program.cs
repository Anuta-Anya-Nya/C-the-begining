// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int[] arr = FillArrNumb(11, 0, 10);
Console.WriteLine($"[{String.Join(", ", arr)}]");
int sum = 0;
for (int i = 1; i < arr.Length; i += 2)
{
    sum += arr[i];
}
Console.WriteLine(sum);