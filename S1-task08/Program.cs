Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2; //Смысла начинать счетчик с 1 нет, т.к. 1 в любом случае не надо выводить
if (number <= 1) 
{ 
    Console.WriteLine("Введено неверное число"); 
}
while (count <= number)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}
