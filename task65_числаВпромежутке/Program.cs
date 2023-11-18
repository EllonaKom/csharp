/*65. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.*/ 

Console.WriteLine("Введите натуральное число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void IntN(int first, int last)
{
    if (last >= first)
    {
        Console.Write(first + " ");
        IntN(first +1, last);
    }
    else
        return;
}

IntN(number1, number2);