/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/ 

Console.WriteLine("Введите натуральное число1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int IntN(int first, int last)
{
    if (last >= first)
    {
        Console.Write(first + " ");
       return  IntN(first +1, last) + first;
    }
    else
        return  0;
             
}

int result = IntN(number1, number2);
System.Console.WriteLine();
Console.Write(result);

