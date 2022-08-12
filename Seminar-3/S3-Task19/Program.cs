//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
string numberStr = Convert.ToString(Math.Abs(Convert.ToInt32(Console.ReadLine()))); 
while (numberStr.Length != 5) 
{
    Console.WriteLine("Введено не пятизначное число!");
    numberStr = Convert.ToString(Math.Abs(Convert.ToInt32(Console.ReadLine()))); 
}

if (int.Parse(numberStr[0].ToString()) == int.Parse(numberStr[4].ToString()) && int.Parse(numberStr[1].ToString()) == int.Parse(numberStr[3].ToString())) //if (number/10000 == number%10 && number%10000/1000 == number%100/10)
{
    Console.WriteLine("Является палиндромом");
}
else {
    Console.WriteLine("Не является палиндромом");
}
// Решение 2, где пятизначное число это массив из 5 цифр
/* int[] fiveNumbers = new int[5];
for (int i = 0; i < 5; i++)
{
    Console.Write($"Введите цифру {i + 1}: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    while (number < 0 || number > 9)
    {
        Console.WriteLine("Введите цифру от 0 до 9");
        number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    }           
    fiveNumbers[i] = number;
}

if (fiveNumbers[0]==fiveNumbers[4] && fiveNumbers[1]==fiveNumbers[3])
{
    Console.WriteLine("Является палиндромом");
}
else
{
    Console.WriteLine("Не является палиндромом");
} */