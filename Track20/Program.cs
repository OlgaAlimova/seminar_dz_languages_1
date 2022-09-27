// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число N ");
Console.Write("N: ");
int n = Convert.ToInt32(Console.ReadLine());
int index = 1;

void Square(int num)
{
    while (index <= n)
    {
        int res = index * index;
        Console.WriteLine($" | {index, 5}  |  {res, 5} |");
        index++;
    }
}

if (n > 0) Square(n);
else Console.WriteLine("Введите корректное знаечение");
