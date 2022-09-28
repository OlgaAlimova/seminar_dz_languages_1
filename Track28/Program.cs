// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A = ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B = ");
int numberB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int num, int degree)
{
    int exponent = 1;
    for(int i = 1; i <= degree; i++)
    {
        exponent = exponent * num;
    }
    return exponent;
}

if (numberB != 0)
{
int exponentResult = Exponentiation(numberA, numberB);
Console.WriteLine($" {numberA} в степени {numberB} = {exponentResult}");
}
else Console.WriteLine($"{numberA} в степени {numberB} = 1 ");
