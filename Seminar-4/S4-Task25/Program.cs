// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int DegreeOfNumb(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= Math.Abs(b); i++)
    {
        result = result * a;
    }
    return result;
}

Console.WriteLine(DegreeOfNumb(3, 5));
Console.WriteLine(DegreeOfNumb(2, 4));