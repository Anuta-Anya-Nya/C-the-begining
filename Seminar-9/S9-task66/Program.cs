// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int M = 4;
int N = 8;
int SumElements(int number1, int number2)
{
    // int sum = 0;
    if (number1 > number2) return 0;
    return number1 + SumElements(number1 + 1, number2);
}

if (M < N)
{
    Console.WriteLine(SumElements(M, N));
}
else
{
    Console.WriteLine(SumElements(N, M));
}
