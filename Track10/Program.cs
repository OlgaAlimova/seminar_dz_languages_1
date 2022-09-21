// Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа
// 456 => 46
// 782 => 72
// 918 => 98

int number = new Random().Next(100, 1000);
//Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int RemoveSecondDigit(int num)
{
    int twoDigit = num % 10;
    int oneDigit = num / 100;
    return oneDigit * 10 + twoDigit;
}
int result = RemoveSecondDigit(number);

Console.WriteLine($"итоговое число от {number} => {result}");

