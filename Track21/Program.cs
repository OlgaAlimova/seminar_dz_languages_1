// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите число от 10000 до 99999 ");
Console.Write("digit =: ");
int digit = Convert.ToInt32(Console.ReadLine());

bool RemoveFifthDigit(int num)
{
    int firstDigit = num % 10; //2
    int arg1 = (num - firstDigit) / 10; //2343
    int secondDigit = arg1 % 10; //3
    int arg2 = (arg1 - secondDigit) / 10; //234
    int thirdDigit = arg2 % 10; //4
    int arg3 = (arg2 - thirdDigit) / 10; //23
    int fourthDigit = arg3 % 10; // 3
    int arg4 = (arg3 - fourthDigit) / 10;
    int fifthDigit = arg4 % 10; // 2
    return ((firstDigit == fifthDigit) && (secondDigit == fourthDigit));
}
if (RemoveFifthDigit(digit)) Console.WriteLine("да");
else Console.WriteLine("нет");


