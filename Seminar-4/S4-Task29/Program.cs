// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void FillArray(int l)
{
    int[] array = new int[l];
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
}

FillArray(8);