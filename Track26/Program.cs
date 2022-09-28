// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int FactorialNumber(int num)
{
    int factori = 1;
    for(int i = 1; i <= num; i++)
    {
        factori = factori * i;
    }
    return factori;
}

if (number > 0)
{
int factorialResult = FactorialNumber(number);
Console.WriteLine($" произведение чисел от 1 до {number} = {factorialResult}");
}
else Console.WriteLine("Введите корректное число");
