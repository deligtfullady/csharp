﻿/*
27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
System.Console.WriteLine("Введите числа А и В: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int SumNumber(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /=10)
    {
        result = result % 10 + i;
    }
    return result;
}
int userResult = SumNumber(userNumber);
//System.Console.WriteLine(${userNumber} ->{userResult});
System.Console.WriteLine(userNumber);
System.Console.WriteLine("->");
System.Console.WriteLine(userResult);