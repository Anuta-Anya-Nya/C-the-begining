// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/* Console.Write("Введите число: ");
string number = Console.ReadLine();

while (!int.TryParse(number, out int _)) //Проверка что введено число, а не текст
{
    Console.Write("Введенные данные текст! Введите число: ");
    number = Console.ReadLine();
}
if (int.Parse(number) >= 0) // если число положительное
{
    if (number.Length <= 2)
    {
        Console.WriteLine($"Третья цифра в числе {number} отсутствует");
    }
    else
    {
        int thirdNumber = int.Parse(number[2].ToString());
        Console.WriteLine($"Третья цифра числа {number} равна {thirdNumber}");
    }
}
else
{
    if (number.Length <= 3) //если число отрицательное
    {
        Console.WriteLine($"Третья цифра в числе {number} отсутствует");
    }
    else
    {
        int thirdNumber = int.Parse(number[3].ToString());
        Console.WriteLine($"Третья цифра числа {number} равна {thirdNumber}");
    }
} */

Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out int number)) //Проверка что введено число, а не текст
{
    Console.Write("Введенные данные - это текст!");
    return;
}
while (number > 999 || number < -999) //Делаем трехзначное число, откидывая последние цифры
{
    number = number / 10;
}
if ((number > 99 && number < 1000) || (number > -999 && number < -99)) // если число трехзначное (положительное и отрицательное)
{
   Console.WriteLine($"Третья цифра числа равна {Math.Abs(number % 10)}"); //Math.Abs(x) модуль
}
else 
{
    Console.WriteLine($"Третья цифра числа отсутствует");
}
