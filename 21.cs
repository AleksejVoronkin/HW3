﻿//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты точки А");


Console.Write("Введите X1 =" + " ");
    double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y1 ="  + " ");
    double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z1 ="  + " ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine("Введите координаты точки B");

Console.Write("Введите X2 =" + " ");
    double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Y2 ="  + " ");
    double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите Z2 ="  + " ");
    double z2 = Convert.ToDouble(Console.ReadLine());

double l = Math.Sqrt( Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.Write("Расстояние между A и B = " + (l));
