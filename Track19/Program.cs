// Math.Pow(2, 10);
// double num = Math.Sqrt(10);
// 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки 1 ");
Console.Write("x1 =: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 =: ");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки 2 ");
Console.Write("x2 =: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 =: ");
double y2 = Convert.ToInt32(Console.ReadLine());

double distance = Distance(x1, y1, x2, y2);
System.Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));

double Distance(double coor1, double coor2, double coor3, double coor4)
{
    // A1A2 = корень из (x2-x1) в квадрате + (y2 - y1) в квадрате
    double res1 = coor3 - coor1;
    double res2 = coor4 - coor2;
    double dist = Math.Sqrt((Math.Pow(res1, 2) + Math.Pow(res2, 2)));
    return dist;
}

