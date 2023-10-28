/*Задача 40: Напишите программу, которая принимает на вход три числа и
проверяет, может ли существовать треугольник с сторонами такой длины.

Теорема о неравенстве треугольника: каждая сторона треугольника
меньше суммы двух других сторон.
*/ 
Console.Clear();


System.Console.Write("Введите число 1: ");
int userA = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 2: ");
int userB = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число 3: ");
int userC = Convert.ToInt32(Console.ReadLine());

bool Triange(int userA, int userB,int userC)
{
    if (userA <  userB + userC && userB < userA + userC && userC < userA + userB)
    {
        return true;
            }
    return false;
}

System.Console.WriteLine(Triange(userA, userB, userC));
