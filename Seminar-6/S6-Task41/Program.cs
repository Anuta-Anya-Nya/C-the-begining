// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void CountPositNumb(int M)
{
    while (M <= 0)
    {
        Console.Write("Введено неверное значение! Введите другое: ");
        M = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[M];
    int count = 0;
    for (int i = 0; i < M; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Введено {count} чисел больше 0"); ;
}
Console.Write("Введите количество цифр: ");
CountPositNumb(Convert.ToInt32(Console.ReadLine()));

