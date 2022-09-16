// Напишите программу, которая на вход
// принимает число и выдаёт его квадрат (число
// умноженное на само себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целове число: ");
int number = Convert.ToInt32(Console.ReadLine());
// 2 147 483 648 до 2 147 483 647 - диапазон int
int square = number * number;
Console.Write($"квадрат числа {number} = {square}");

//if (number == square) Console.WriteLine(number);


