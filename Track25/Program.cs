// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());


int QuantityNumbers(int num)
{
    int j = 0;
    while (num > 0)
    {
        num = (num - (num % 10)) / 10;
        j++;
    }
    return j;
}
if (number > 9)
{
    int res = QuantityNumbers(number);
    Console.WriteLine($"Число {number} состоит из {res} цифр");
}
else Console.WriteLine("Число состоит из одной цифры");



// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// int QuantityNumbers(int num)
// {
// int counter = 0;
// while (num > 0)
// {
// num = num / 10;
// counter++;
// }
// return counter;
// }
// int res = QuantityNumbers(number);
// Console.WriteLine(res);


// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// int QuantityNumbers(int num)
// {
// int counter = 0;
// while (num > 0)
// {
// num = num / 10;
// counter++;
// }
// return counter;
// }
// int res = QuantityNumbers(Math.Abs(number));
// Console.WriteLine(res);