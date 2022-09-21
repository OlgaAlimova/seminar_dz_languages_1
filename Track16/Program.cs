// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является 
//ли этот день выходным
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите целое число от 1 до 7, обозначающее день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

// первый вариант решения

// if (day == 1) Console.WriteLine("нет, понедельник рабочий день");
// else if (day == 2) Console.WriteLine("нет, вторник рабочий день");
// else if (day == 3) Console.WriteLine("нет, среда рабочий день");
// else if (day == 4) Console.WriteLine("нет, четверг рабочий день");
// else if (day == 5) Console.WriteLine("нет, пятница рабочий день");
// else if (day == 6) Console.WriteLine("да, суббота выходной");
// else if (day == 7) Console.WriteLine("да, воскресенье выходной");
// else Console.WriteLine("введите верное число");

// второй вариант решения

if (day <= 5 && day >= 1)
{
    Console.WriteLine("нет, это рабочий день");
}
else if (day <= 7 && day >= 6) Console.WriteLine("да, это выходной");
else Console.WriteLine("введите верное число");