// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void Fibon(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < 2; i++)
    {
        array[i] = i;
        Console.Write(array[i] + " ");
    }
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i - 2] + array[i - 1];
        Console.Write(array[i] + " ");
    }
}
Fibon(7);