// Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, 
//либо можете сами задавать массив чисел) и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
void FillArray(int l)
{
    int[] array = new int[l];
    int[] newArray = new int[l];
    int multipl = 1;
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
        if (array[i] == 0) // если число нулевое, вычислить произведение нельзя, будем считать, что произведение равно 0
        {
            multipl = 0;
        }
        else 
        {
            for (int j=1; j<=Math.Abs(array[i]); j++)
            {
                multipl = multipl * j;            
            }
        }
        
        newArray[i]=multipl;
        multipl = 1;
    }
    Console.WriteLine($"Массив чисел: [{String.Join(", ", array)}]");
    Console.WriteLine($"Массив произведений: [{String.Join(", ", newArray)}]");
}
FillArray(3);