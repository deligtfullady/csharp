/*
на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно)
*/ 

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i+=2)
{
    System.Console.Write(i + "\t");
}