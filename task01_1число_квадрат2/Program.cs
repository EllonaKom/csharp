﻿/*Напишите программу, которая на вход принимает два числа и проверяет, является 
ли первое число квадратом второго. 

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет */



System.Console.WriteLine("Введите число 1");

int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber2 * userNumber2 == userNumber1)
{
     System.Console.WriteLine($"Да. Первое число: {userNumber1} квадрат второго: {userNumber2} ");
}
else
{
      System.Console.WriteLine($"Нет. Первое число: {userNumber1} не квадрат второго: {userNumber2} ");
}

