// Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целове число b: ");
int b = Convert.ToInt32(Console.ReadLine());

bool Square(int arg1, int arg2)
{
    return ((arg1*arg1 == arg2) || (arg2*arg2 == arg1));
}
if (Square(a, b)) Console.WriteLine("да");
else Console.WriteLine("нет");
