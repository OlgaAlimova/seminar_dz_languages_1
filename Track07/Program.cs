// Напишите программу, которая на вход принимает число и выдает
// является ли число четным (делится ли оно на два без остатка)


Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

int res = a % 2;
if (res == 0)
{
    Console.Write("да");
}
else Console.Write("нет");


