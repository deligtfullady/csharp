"/*
""Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.""
*/
using System;
Console.Clear();

void PrintArray(int[] array)
{
    System.Console.Write(""["");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write("", "");
    }
    System.Console.WriteLine(""]"");
}

int TakeEntNum(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] TakeArray (string message, int size)
{
    
    int[] result = new int[size];
    
    for (int i = 0; i < size; i++)
    {
        result[i] = TakeEntNum(message);    
    }
    return result;
}

int CountPositiveNum (int[] array)
{

 int result = 0;
 for (int i = 0; i < array.Length; i++)
 {
    if (array[i] > 0) result +=array[i];
 }
 return result;
}


int userArraySize = TakeEntNum (""Please, enter array size:"");
int[] userArray = TakeArray(""Please, enter number for array:"", userArraySize);
int userPosNumCount = CountPositiveNum(userArray);
PrintArray (userArray);
System.Console.WriteLine(userPosNumCount);
"
