/* 65. Выполнение через рекурсию (функция вызывает саму себя)
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N.
*/

Console.Clear(); 

Console.Write(«Введите значение M: «);
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(«Введите значение N: «);
int n = Convert.ToInt32(Console.ReadLine());
void intN(int first, int last)
{
    if (first >= last)
    {
        System.Console.WriteLine(first + " ");
        intN(first +1, last);
    }

    else
        return;
}
intN(number1, number2);



