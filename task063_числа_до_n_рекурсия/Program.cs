/*
63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
*/

Console.Clear();

System.Console.WriteLine("Введите числo: ");
int number = Convert.ToInt32(Console.ReadLine());

void intN(int number, int current = 1)
{
    if (current >= number)
    {
    System.Console.WriteLine(current + " ");
    intN(number, current + 1);
    }
    else
        return;
}
intN(number);