// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// А(3, 6, 8); B(2, 1, -7) -> 15,84
// А(7, -5, 0); B(1, -1, 9) -> 11,53

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double h = 0;
    h = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    h = Math.Round(h, 2);  //округление до второго знака после запятой
    return h;
}

Console.WriteLine("Введите поочередно координаты (X, Y, Z) первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите поочередно координаты (X, Y, Z) второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(result);
