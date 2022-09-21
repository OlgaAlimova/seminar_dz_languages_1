// Напишите программу, которая будет принимать на вход
// два числа и выводить, является ли второе число кратным
// первому. Если число 1 не кратно числу 2, то программа
// выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целове число b: ");
int b = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int arg1, int arg2)
{
    return arg1 % arg2 == 0;  
}
if (Multiplicity(a, b)) Console.WriteLine($" Число {a} кратно {b}");
else Console.WriteLine($"остаток от деления {a} на {b} = {a % b}");

