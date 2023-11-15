/*
42: Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBool( int number)
{
    int result= 0;
    int count = 1;
    while(number>0)
    {
        result=number%2*count+result;
        number=number/2;
        count=count*10;
    }
return result;
}
int Number = ToBool(number);
Console.Write(Number);
/*
Console.Clear();
string Conv(int number)
{
    string result = "";
    int tmp = 0;
    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;
}

int uNum = UserInOut("Введите число: ");
System.Console.WriteLine(Conv(uNum));
*/