// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125


int CubeNum(int x)
{
    int i = 1;
    while (i<=x)
    {
        Console.WriteLine(Convert.ToInt32(Math.Pow(i, 3)));
        i++;
    }
    return x;
}

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int result = CubeNum(x);
Console.WriteLine(result);

