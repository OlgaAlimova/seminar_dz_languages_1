// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть, в которой находится точка ");
Console.Write("xyC: ");
int xyC = Convert.ToInt32(Console.ReadLine());

void Quarter(int chet)
{
    if (chet == 1) Console.WriteLine("x > 0, y > 0");
    else if (chet == 2) Console.WriteLine("x < 0, y > 0");
    else if (chet == 3) Console.WriteLine("x < 0, y < 0");
    else if (chet == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("Введены некорректные данные");
}

Quarter(xyC);

//2 вариант

Console.WriteLine("Введите четверть, в которой находится точка ");
Console.Write("xyC: ");
int quater = Convert.ToInt32(Console.ReadLine());
string result = QuarterStr(quater);
System.Console.WriteLine(result);

string QuarterStr(int quart)
{
if( quart == 1) return "x > 0 && y > 0";
if( quart == 2) return "x < 0 && y > 0";
if( quart == 3) return "x < 0 && y < 0";
if( quart == 4) return "x > 0 && y < 0";
return "Введены некоректные координаты";
}
