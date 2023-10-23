﻿/*
20. Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/ 

System.Console.WriteLine("Введите координаты точки A (x,y): "); // cw - быстрый вызов Console.WriteLine
int userAx = Convert.ToInt32(Console.ReadLine());
int userAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координаты точки B (x,y): "); // cw - быстрый вызов Console.WriteLine
int userBx = Convert.ToInt32(Console.ReadLine());
int userBy = Convert.ToInt32(Console.ReadLine());

int squareX = (userBx - userAx) * (userBx - userAx);
double squareX = Math.Pow(userBx - userAx, 2); // Math.Pow(а, 3) функция возведения в степень(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);//Math.Sqrt находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2));//Math.Round (а, 2) округление числа (число, сколько чисел после запятой оставить)
/*double squareX = Math.Pow(userBx - userAx, 2); // Math.Pow(a, 3) функция возведения в степень,(что возводим в степень, в какую степень)
double squareY = Math.Pow(userBy - userAy, 2);
double rootXY = Math.Sqrt(squareX + squareY); // Math.Sqrt(то, что идет на вход) находит квадратный корень
System.Console.WriteLine(Math.Round(rootXY, 2)); // Math.Round(a, 2) округление чисел после запятой(число, сколько чисел после запятой оставить)
*/