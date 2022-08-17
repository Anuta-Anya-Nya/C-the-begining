// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int SumNumbers(int a)
{
    string numbString = Convert.ToString(Math.Abs(a));
    int sum = 0;
    for (int i = 0; i < numbString.Length; i++)
    {
        sum = sum + Convert.ToInt32(numbString[i].ToString());
    }
    return sum;
}
Console.WriteLine(SumNumbers(452)); 
Console.WriteLine(SumNumbers(82)); 
Console.WriteLine(SumNumbers(9012));

int SumNumbers2(int a)
{
    int sum = 0;
    int b=Math.Abs(a);
    while (b>0)
    {
        sum=sum + b%10;
        b=b/10;
    }
    return sum;
}
Console.WriteLine(SumNumbers2(452));
Console.WriteLine(SumNumbers2(82));
Console.WriteLine(SumNumbers2(9012));