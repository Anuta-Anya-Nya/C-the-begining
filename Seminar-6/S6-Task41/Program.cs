// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void CountPositNumb(int leng)
{
    while (leng <= 0)
    {
        Console.Write("Введено неверное значение! Введите другое: ");
        leng = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[leng];
    int count = 0;
    for (int i = 0; i < leng; i++)
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

