// Напишите программу, которая принимает на вход
// трехзначное число и на выходе показывает вторую
// цифру этого числа
// 456 ->5
// 782 ->8
// 918 ->1

int number = new Random().Next(100, 1000);
//Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int RemoveSecondDigit(int num)
{
    int twoDigit = num % 10;
    int oneDigit = num / 100;
    return (num - (oneDigit * 100 + twoDigit))/10;
}
int result = RemoveSecondDigit(number);

Console.WriteLine($"вторая цифра числа {number} => {result}");


