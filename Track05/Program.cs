// Напишите программу, которая на вход принимает два числа и выдает,
// какое число больше, а какое меньше

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целове число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.Write("a - больше, b - меньше");
}
else Console.Write("b - больше, a - меньше");

