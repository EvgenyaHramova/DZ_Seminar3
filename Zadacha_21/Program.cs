// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние
// между ними в 3D пространстве.
// А(3, 6, 8); B(2, 1, -7) -> 15,84
// А(7, -5, 0); B(1, -1, 9) -> 11,53

string Palindrome(int num)
{
    string text = "";
    //int a = num / 1000;
    //int b = num % 100;
    int a1 = (num / 1000) / 10;
    int a2 = (num / 1000) % 10;
    int a4 = (num % 100) / 10;
    int a5 = (num % 100) % 10;
    if (a1 == a5 && a2 == a4 && num > 0)
    {
        text = "Число является палиндромом.";
    }
    else
    {
        text = "Число не является палиндромом.";
    }
    return text;
}

Console.WriteLine("Введите пятизначное число: ");
int fiveNum = Convert.ToInt32(Console.ReadLine());

string result = Palindrome(fiveNum);
Console.WriteLine(result);
