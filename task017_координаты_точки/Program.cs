﻿/*
17. Напишите программу, которая принимает на вход
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
номер четверти плоскости, в которой находится эта
точка.
*/ 

System.Console.WriteLine("Введите координаты точки. Х: "); // cw - быстрый вызов Console.WriteLine
int userX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки. Y: ");
int userY = Convert.ToInt32(Console.ReadLine());

if(userX > 0 && userY > 0)
{
    System.Console.WriteLine("точка находится в первой четверти");
}
if(userX < 0 && userY > 0)
{
    System.Console.WriteLine("точка находится во второй четверти");
}
if(userX < 0 && userY < 0)
{
    System.Console.WriteLine("точка находится в третьей четверти");
}
if(userX > 0 && userY < 0)
{
    System.Console.WriteLine("точка находится в четвертой четверти");
}
if(userX == 0 || userY == 0)
{
    System.Console.WriteLine("точка находится на оси координат");
}