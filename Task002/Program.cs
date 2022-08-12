// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату xa");
double xa = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату ya");
double ya = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату za ");
double za = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату xb ");
double xb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату yb ");
double yb = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координату zb ");
double zb = double.Parse(Console.ReadLine());
void distance(double xa, double ya, double za, double xb, double yb, double zb)
{
    double dist = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
    Console.WriteLine(dist);
}
Console.Write("Расстояние между точками в 3D пространстве составляет ");
distance(xa, ya, za, xb, yb, zb);