/* 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да

*/

System.Console.WriteLine("Введите пятизначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result1 = userNumber % 10;
int result2 = userNumber / 10 % 10;
int result3 = userNumber / 1000 % 10;
int result4 = userNumber / 10000 % 10;

if (result1 == result4 & result2 == result3)
{
    System.Console.WriteLine("Да.Палиндром.");
}
else
{
    System.Console.WriteLine("Нет.Не палиндром.");
}