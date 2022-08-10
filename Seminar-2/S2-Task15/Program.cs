Console.Write("Введите номер дня недели: ");
if (!int.TryParse(Console.ReadLine(), out int number)) //Проверка что введено число, а не текст
{
    Console.Write("Введенные данные - это текст!");
    return;
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Выходной");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine("Рабочий");
}
else
{
    Console.WriteLine("Введено неверное число!");
}