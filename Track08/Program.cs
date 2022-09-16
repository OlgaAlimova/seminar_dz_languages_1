// Напишите программу, которая на вход принимает число (N), а на
// выходе показывает все четные числа от 1 до N

Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current < n)
{
    Console.Write($"{current}");
    current = current + 2;
}

