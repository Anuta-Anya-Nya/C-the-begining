//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[] GetRandomUniqNumber(int startNumb, int endNumb) //метод создает массив последовательных чисел и перемешивает его, для выбора уникального числа
{
    int[] numbers = new int[endNumb - startNumb + 1];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = startNumb + i;
    }

    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int index = new Random().Next(i + 1, numbers.Length);
        int temp = numbers[i];
        numbers[i] = numbers[index];
        numbers[index] = temp;
    }
    return numbers;
}

int startNum = 10,
    endNum = 99,
    count = 10;
int[] numbersUniq = GetRandomUniqNumber(startNum, endNum);
int[,,] array = new int[2, 2, 2];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = numbersUniq[count];
            Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            count++;
        }
        Console.WriteLine();
    }
}
