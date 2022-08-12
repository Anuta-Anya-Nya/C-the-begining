//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
void FillDotArray(int[] array)
{
    Console.WriteLine("Введите координаты точки.");
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Введите координату{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] dotA = new int[3];
int[] dotB = new int[3];
FillDotArray(dotA);
FillDotArray(dotB);
double length = Math.Sqrt(Math.Pow((dotA[0] - dotB[0]), 2) + Math.Pow((dotA[1] - dotB[1]), 2) + Math.Pow((dotA[2] - dotB[2]), 2));
Console.WriteLine("Расстояние между точкой А и В равно: " + length + "!");
