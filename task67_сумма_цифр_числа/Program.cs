﻿/*67. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.*/ 

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int IntN(int n)
{
    if (n % 10 > 0) return n % 10 + intN(n / 10);
    else
        return 0;
}

int result = IntN(number);
Console.WriteLine(result);

