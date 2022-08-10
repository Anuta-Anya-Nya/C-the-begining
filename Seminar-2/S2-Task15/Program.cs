// Вводим цифру, программа пишет выходной или рабочий
void WhatDayOfTheWeek (string numberStr)
{
while (!int.TryParse(numberStr, out int _)) //Проверка что введено число, а не текст
{
    Console.Write("Введенные данные - это текст! Введите заново номер дня недели: ");
    numberStr = Console.ReadLine();
}
int number = Convert.ToInt32(numberStr);
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
}
Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine();
WhatDayOfTheWeek(day);
Console.Write("А еще раз номер дня недели: ");
day = Console.ReadLine();
WhatDayOfTheWeek(day);