// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125


void PrintCube(int x)
{
    int i = 1;
    while (i<=x)
    {
        Console.WriteLine(Convert.ToInt32(Math.Pow(i, 3)));// возведение в степень и перевод
        i++;
    }
}

Console.Write("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

PrintCube(x);
