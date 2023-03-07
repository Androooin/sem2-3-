// Задача 21

// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координату X точки A");
int Xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A");
int Ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int Za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B");
int Xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B");
int Yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int Zb = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((Xa - Xb) * (Xa - Xb) + (Ya - Yb) * (Ya - Yb) + (Za - Zb) * (Za - Zb));
Console.WriteLine(distance);