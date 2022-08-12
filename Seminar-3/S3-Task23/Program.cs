//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число N: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (N == 0)
{
    Console.WriteLine("Вводить 0 нельзя!");
}
else
{
    for (int i = 1; i <= N; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}
