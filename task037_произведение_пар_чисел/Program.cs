"/*
37. Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
using System;
Console.Clear();

/*
int[] MultiplyArrayFromSide(int[] array)
{
    int size = array.Length / 2;
    int[] multiarray = new int[size];
    for (int i = 0; i < size; i++)
    {
        multiarray[i] = array[i] * array[array.Length - i -1];
    }
    if (array.Length % 2 != 0)
        multiarray[size - 1] = array[size - 1];
    return multiarray;
}
*/

int[] MultiplyArrayFromSide(int[] array)
{
    int size = array.Length - array.Length / 2;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
        result[size - 1] = array[size - 1];
    return result;
}


int[] GetRandomArray(int start, int end, int lenght)
{
    int[] array = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

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

int userArraySize = TakeEntNum(""Please, enter array size:"");
int userArrayStart = TakeEntNum(""Please, enter array start number range:"");
int userArrayEnd = TakeEntNum(""Please, enter array end number range:"");

int[] userArray = GetRandomArray(userArrayStart, userArrayEnd, userArraySize);
int[] userMultiArray = MultiplyArrayFromSide(userArray);
PrintArray(userArray);
PrintArray(userMultiArray);
"
