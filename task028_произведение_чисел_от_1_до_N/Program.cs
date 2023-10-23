/*
28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/

System.Console.WriteLine("Введите число А: ");

int userA = Convert.ToInt32(Console.ReadLine());

int Num(int a)
{
   int sum = 1;

    for (int i = 1; i <= a; i++)
{
    sum = sum * i;
}
    return sum;
}
int userResult = Num(userA);
System.Console.WriteLine(userResult);