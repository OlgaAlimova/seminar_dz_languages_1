// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int sum = default;
    for(int i = 0; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int SumNumber2(int num)
{
    int sum = default;
    int counter = 1;
    while(counter <= num)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}

int sumResult = SumNumber(number);
int sumResult2 = SumNumber2(number);
Console.WriteLine(sumResult);
Console.WriteLine($"сумма чисел от 1 до {number} = {sumResult2}");

