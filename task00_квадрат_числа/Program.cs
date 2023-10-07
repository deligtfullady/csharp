/*
0. Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
разбор
*/

System.Console.WriteLine("Введите число: "); // cw - быстрый вызов Console.WriteLine
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

Console.WriteLine(result);
Console.WriteLine(userNumber * userNumber);
