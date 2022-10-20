// Задача 21

// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты двух точек в 3D пространстве");
Console.Write("Первая точка, координата X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка, координата Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Первая точка, координата Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка, координата X: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка, координата Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вторая точка, координата Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xc1, int yc1, int zc1, int xc2, int yc2, int zc2)
{
    int rx = xc1 - xc2;
    int ry = yc1 - yc2;
    int rz = zc1 - zc2;
    return Math.Sqrt(rx * rx  + ry * ry  + rz * rz );
}

double result = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками: {result}");