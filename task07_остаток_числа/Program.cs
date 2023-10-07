//7. Напишите программу, которая принимает на вход трехзначное число, возвращает правое..
// 456 -- 6
// 782 -- 2
System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 10;
Console.WriteLine(result);
