/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number<100 || number>999) // ПРоверка на трехзначность
{
    Console.Write("Введенное число не трехзначное! Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int remainder = number % 100; // остаток равен последним 2 цифрам
int result = remainder / 10;
Console.WriteLine($"Вторая цифра числа {number} равна {result}");