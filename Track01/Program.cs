// напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго
//a = 25, b = 5 -> да
//a = 2, b = 10 -> нет
//a = 9, b = -3 -> да
//a = -3 b = 9 -> нет

Console.Write("Введите целое число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целове число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int square = b * b;
if (a == square)
{
    Console.WriteLine("верно");
}
else Console.WriteLine("ошибка");

