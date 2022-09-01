// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
int FuncAkkerman(int n, int m)
{
    if (n == 0) return m + 1;
    else if (n > 0 && m == 0)
    {
        return FuncAkkerman(n - 1, 1);
    }
    else
    {
        return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));
    }

}
int m = 2, n = 3;
Console.WriteLine(FuncAkkerman(n, m));