"/*
""52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.""
*/

using System;
Console.Clear();

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($""{matrix[i, j]}\t"");
        }
        System.Console.WriteLine();
    }

}


int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array = new int[n, m];
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = result;
            result += k;
        }
    }
    return array;
}

void PrintListAvr(double[] list)
{
    for (int i = 0; i < list.Length; i++)
    {
        System.Console.WriteLine($""Average of column {i} is {list[i]}"");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sumColumn = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumn += matrix[i, j];
        }
        double midresult;
        midresult = Convert.ToDouble(sumColumn) / Convert.ToDouble((matrix.GetLength(0) + 1));
        result[j] = Math.Round(midresult, 2);
    }
    return result;
}

int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int userRow = TakeEnteredNumber(""Кол-во строк:"");
int userColumn = TakeEnteredNumber(""Кол-во столбцов:"");
int userIncrement = TakeEnteredNumber(""Введите инкремент для матрицы: "");
int[,] userMatrix = CreateIncreasingMatrix(userRow, userColumn, userIncrement);
PrintArray(userMatrix);
double[] userRowAverage = FindAverageInColumns(userMatrix);
PrintListAvr(userRowAverage);"
