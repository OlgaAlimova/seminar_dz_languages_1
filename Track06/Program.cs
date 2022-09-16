// Напишите программу, которая принимает на вход три числа и 
// выдает максимальное из этих чисел

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целове число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.Write("число a максимальное");
    }
    else Console.Write("число c макимальное");
}
else if (b > c)
     {
         Console.Write("число b максимальное");
     }
     else Console.Write("число c максимальное");