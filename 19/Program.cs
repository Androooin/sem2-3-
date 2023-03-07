//Задача 19
// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное  число ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 9999)
{
    if (num < 100000)
    {
      int a = (num / 10000);
      int b = (num % 10);
      int c = (num / 1000 % 10);
      int d = (num % 100 / 10);
        if (a == b && c == d)
        {
        Console.WriteLine($"{num} палиндром");
        }
        else
        {
            Console.WriteLine($"{num} не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Это не пятизначное число");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}
