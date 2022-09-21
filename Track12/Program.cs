// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

bool Multiplicity(int arg)
{
    return ((arg % 7 == 0) && (arg % 23 == 0));
}
if (Multiplicity(a)) Console.WriteLine("да");
else Console.WriteLine("нет");
