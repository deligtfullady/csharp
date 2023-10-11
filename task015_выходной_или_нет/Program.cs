/*
15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Clear();
Console.WriteLine("Введите номер дня недели от 1 до 7: ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber <=5 && dayNumber > 0)
{
    System.Console.WriteLine("Это рабочий день!");
}
if (dayNumber == 6 || dayNumber ==7)
{
    System.Console.WriteLine("Ура выходной!");
}
else if (dayNumber < 1 || dayNumber > 7)
{
    System.Console.WriteLine("Такого дня недели не сущесtвует!");
}
/*if (dayNumber == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (dayNumber == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (dayNumber == 3)
{
    System.Console.WriteLine("Среда");
}
else if (dayNumber == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (dayNumber == 5)
{
    System.Console.WriteLine("Пятница");
}
else if (dayNumber == 6)
{
    System.Console.WriteLine("Суббота");
}
else if (dayNumber == 7)
{
    System.Console.WriteLine("Воскресенье");
}
else {System.Console.WriteLine("Ошибка");}
*/