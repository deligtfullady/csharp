// Программа, которая на вход принимает два числа и выводит, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
    {
        Console.WriteLine($"Первое число " '{firstNumber}'  " больше, чем второе" '{secondNumber}');
    }
else if(firstNumber == secondNumber)
    {
        Console.WriteLine($"Оба числа равны {firstNumber}");
    }

else if
       Console.WriteLine($"Первое число " {firstNumber} " меньше, чем второе" {secondNumber});
