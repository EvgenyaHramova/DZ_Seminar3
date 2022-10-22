// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

string Palindrome(int num)
{
    string text = "";
    int a = num / 1000;
    int b = num % 100;
    int a1 = a / 10;
    int a2 = a % 10;
    int a4 = b / 10;
    int a5 = b % 10;
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