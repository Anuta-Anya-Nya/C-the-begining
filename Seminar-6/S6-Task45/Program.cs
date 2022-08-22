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
int[] copyArray(int[] collect) //void???
{
    int[] newArray = new int[collect.Length];
    for (int i = 0; i < collect.Length; i++)
    {
        newArray[i] = collect[i];
    }
    return newArray;
}
int[] someNumbers = FillArrNumb(15, 0, 10);
Console.WriteLine($"[{String.Join(", ", someNumbers)}]");
Console.WriteLine($"[{String.Join(", ", copyArray(someNumbers))}]"); //разобраться, какая функция void
