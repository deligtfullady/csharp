/* Напишите программу, которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.

456 -> 6
782 -> 2
918 -> 8
*/

System.Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 10;
System.Console.WriteLine(result);