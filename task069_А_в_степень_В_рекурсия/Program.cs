/* 69. Выполнение через рекурсию (функция вызывает саму себя)
Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
*/

Console.Clear(); 

Console.Write("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int intN(int n1, int n2)
{
    if (n2 == 1) return n1;
    else
        return n1 * intN(n1, n2 -1);
}
int result = intN(number1, number2);
System.Console.WriteLine(result);
