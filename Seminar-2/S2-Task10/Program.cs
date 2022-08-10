/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

void FindSecondNumber(string s)
{
    while (!int.TryParse(s, out int result) || Math.Abs(result) < 100 || Math.Abs(result) > 999)
    {
        Console.Write("Введенные данные текст или не трехзначное число! Введите трехзначное число: ");
        s = Console.ReadLine();
    }
    int number = Convert.ToInt32(s);
    int secondNumber = Math.Abs(number) % 100 / 10;
    Console.WriteLine($"Вторая цифра числа {number} равна {secondNumber}");
}
//Решение 2: 
void FindSecondNumber2( string str)
{
    while (!int.TryParse(str, out int result) || Math.Abs(result) < 100 || Math.Abs(result) > 999)
    {
        Console.Write("Введенные данные текст или не трехзначное число! Введите трехзначное число: ");
        str = Console.ReadLine();
    }
    int secondNumber = 0;
    if (Convert.ToInt32(str) > 0)
    {
        secondNumber = int.Parse(str[1].ToString());
    }
    else
    {
        secondNumber = int.Parse(str[2].ToString());
    }
    Console.WriteLine($"Вторая цифра числа {str} равна {secondNumber}");
}

Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();
FindSecondNumber(number);
FindSecondNumber2(number);