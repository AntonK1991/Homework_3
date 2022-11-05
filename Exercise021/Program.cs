//* Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.

void PointDistanceFind(double xa, double xb, double ya, double yb, double za, double zb)
{
    double result = (xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb);
    result = Math.Sqrt(result);
    Console.WriteLine("Расстояние между точками: " + Math.Round(result, 2));
}

void Insert(out double xa, out double xb, out double ya, out double yb, out double za, out double zb)
{
    Console.Write("Введите координату первой точки по оси Х: ");
    xa = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату второй точки по оси Х: ");
    xb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату первой точки по оси Y: ");
    ya = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату второй точки по оси Y: ");
    yb = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату первой точки по оси Z: ");
    za = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату второй точки по оси Z: ");
    zb = Convert.ToInt32(Console.ReadLine());   
}

double xa, xb, ya, yb, za, zb;

Insert(out xa, out xb, out ya, out yb, out za, out zb);

PointDistanceFind(xa, xb, ya, yb, za, zb);