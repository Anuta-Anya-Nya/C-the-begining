//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] FillArrNumb(int leng, int numMin, int numMax) // создает массив заданной длины, с элементами в заданном промежутке
{
    while (leng <= 0)
    {
        Console.WriteLine("Введено неверное значение! Введите другое: ");
        leng = Convert.ToInt32(Console.ReadLine());
    }
    int[] array = new int[leng];
    for (int i = 0; i < leng; i++)
    {
        array[i] = new Random().Next(numMin, numMax + 1);
    }
    return array;
}
int[] copyArrNumb(int[] collect) //void???
{
    int[] newArray = new int[collect.Length];
    for (int i = 0; i < collect.Length; i++)
    {
        newArray[i] = collect[i];
    }
    return newArray;
}
const int LENG = 15;
const int MIN_NUMB = 0;
const int MAX_NUMB = 10;
int[] arrNumbers = FillArrNumb(LENG, MIN_NUMB, MAX_NUMB);
int[] copyArrNumbers = copyArrNumb(arrNumbers);
Console.WriteLine($"[{String.Join(", ", arrNumbers)}]");
Console.WriteLine($"[{String.Join(", ", copyArrNumbers)}]");
