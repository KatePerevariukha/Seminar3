﻿Console.Write("Введите координату x1 для точки A:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y1 для точки A:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z1 для точки A:");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату x2 для точки B:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату y2 для точки B:");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату z2 для точки B:");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)));