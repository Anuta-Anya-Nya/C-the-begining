// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
//4 -> 24
//5 -> 120
int Factorial(int N)
{
    if (N == 1) return 1;
    return N * Factorial(N - 1);
}
Console.WriteLine(Factorial(5));