// Программа, которая на вход принимает два числа и выводит, какое число большее, а какое меньшее

Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
{
    static void CompareNumbers(int firstNumber, int secondNumber)
    {

        if (firstNumber > secondNumber)
        {
            Console.Write("Первое число " + firstNumber + " больше, чем второе" + secondNumber +);
        }
        else firstNumber == secondNumber
        {
            Console.Write("Оба числа равны " + firstNumber +);
        }

      else
            Console.Write("Первое число " + firstNumber + " меньше, чем второе" + secondNumber +);
    }
}