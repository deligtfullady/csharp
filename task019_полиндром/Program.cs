/*
принимает на вход пятизначное число number и проверяет, является ли оно палиндромом
*/ 

Console.Clear();
/*
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int n1 = n / 10000;
System.Console.WriteLine(n1);
int n2 = n / 1000 % 10;
System.Console.WriteLine(n2);
int n4 = n / 10 % 10;
System.Console.WriteLine(n4);
int n5 = n % 10;
System.Console.WriteLine(n5);
if (n >=10000 & n <= 99999)
{
    if (n1 == n5 & n2 == n4)
    {
        System.Console.WriteLine("Да");
    }
    else
    {
        System.Console.WriteLine("Нет");
    }
}
else
{
    System.Console.WriteLine("Число не пятизначное");
}
*/
System.Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int revN = 0;
for (int i = N; i > 0; i/=10)
{
   revN = revN * 10 + i % 10;
   //System.Console.WriteLine(revN); 
}
if (N == revN)
{
    System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}
/*
System.Console.Write("набирите пятизначное число: ");
int val = Convert.ToInt32(Console.ReadLine());
if(val <= 99999 && val >= 10000);
{
    System.Console.WriteLine("пятизначное цифры нет");
}
int rev = 0;
while(val != 0)
{
    rev = rev * 10 + val % 10;
    val /= 10;
}
string str = rev.ToString();
Console.WriteLine($"{str[0]} {str[1]} {str[3]} {str[4]}");
if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine($"Евляется полидромом {str[0]} {str[1]} {str[3]} {str[4]}");
}
else
{
    Console.WriteLine("Число не палидром");
}
*/