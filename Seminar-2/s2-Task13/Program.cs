// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// в методе 2 подумать и переделать ветвление, используя модуль
void FindThirdNumber2(string numStr)
{
    while (!int.TryParse(numStr, out int _)) //Проверка что введено число, а не текст
    {
        Console.Write("Введенные данные текст! Введите число: ");
        numStr = Console.ReadLine();
    }
    if (int.Parse(numStr) >= 0) // если число положительное
    {
        if (numStr.Length <= 2)
        {
            Console.WriteLine($"Третья цифра в числе {numStr} отсутствует");
        }
        else
        {
            int thirdNumber = int.Parse(numStr[2].ToString());
            Console.WriteLine($"Третья цифра числа {numStr} равна {thirdNumber}");
        }
    }
    else
    {
        if (numStr.Length <= 3) //если число отрицательное
        {
            Console.WriteLine($"Третья цифра в числе {numStr} отсутствует");
        }
        else
        {
            int thirdNumber = int.Parse(numStr[3].ToString());
            Console.WriteLine($"Третья цифра числа {numStr} равна {thirdNumber}");
        }
    }
}
void FindThirdNumber(string numberStr)
{
    while (!int.TryParse(numberStr, out int number)) //Проверка что введено число, а не текст
    {
        Console.Write("Введенные данные - это текст! Введите число: ");
        numberStr = Console.ReadLine();
    }
    int numberPositive = Math.Abs(Convert.ToInt32(numberStr));

    while (numberPositive > 999) //Делаем трехзначное число, откидывая последние цифры
    {
        numberPositive = numberPositive / 10;
    }
    if (numberPositive > 99 && numberPositive < 1000)  // если число трехзначное (положительное и отрицательное)
    {
        Console.WriteLine($"Третья цифра числа {numberStr} равна {numberPositive % 10}"); //Math.Abs(x) модуль
    }
    else
    {
        Console.WriteLine($"Третья цифра числа отсутствует");
    }
}
Console.Write("Введите число: ");
string num = Console.ReadLine();
FindThirdNumber(num);
FindThirdNumber2(num);