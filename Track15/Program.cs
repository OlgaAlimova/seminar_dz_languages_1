// Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет
// 645 -> 5
// 78 -> третьей ыифры нет
// 3267 -> 6

Console.Write("Введите целое число a: ");
int a = Convert.ToInt32(Console.ReadLine());

string numberText = Convert.ToString(a);
if (numberText.Length > 2)
{
  Console.WriteLine($"третья цифра -> {numberText[2]}");
}
else Console.WriteLine("третьей цифры нет");

