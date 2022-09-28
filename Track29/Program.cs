// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


int SumNumbers(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int arg = num % 10;
        num = (num - arg) / 10;
        sum = sum + arg;
    }
    return sum;
}
if (number >= 0)
{
    int res = SumNumbers(number);
    Console.WriteLine($"Сумма цифр числа {number} = {res}");
}
else Console.WriteLine("Введите корректное число");