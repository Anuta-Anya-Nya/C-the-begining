/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.Write("Введите трехзначное число: ");
string numberStr = Console.ReadLine();

while (!int.TryParse(numberStr, out int result) || Math.Abs(result) < 100 || Math.Abs(result) > 999)
{
    Console.Write("Введенные данные текст или не трехзначное число! Введите трехзначное число: ");
    numberStr = Console.ReadLine();
}
int number = Convert.ToInt32(numberStr);
int secondNumber = Math.Abs(number)%100/10;
Console.WriteLine($"Вторая цифра числа {number} равна {secondNumber}");

/* int number = Convert.ToInt32(Console.ReadLine());
int numberPos = Math.Abs(number);
while (numberPos < 100 || numberPos > 999 ) // ПРоверка на трехзначность
{
    Console.Write("Введенное число не трехзначное! Введите трехзначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    numberPos = Math.Abs(number);
}

result = numberPos % 100 / 10; // остаток равен последним 2 цифрам

*/
//Решение 2: number.Length != 4
/* Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();

while (!int.TryParse(number, out int result) || Math.Abs(result) < 100 || Math.Abs(result) > 999)
{
    Console.Write("Введенные данные текст или не трехзначное число! Введите трехзначное число: ");
    number = Console.ReadLine();
}

int secondNumber = int.Parse(number[1].ToString());

Console.WriteLine($"Вторая цифра числа {number} равна {secondNumber}"); */
