/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29

A(m,n)= n+1       m=0
A(m,n)= A(m-1,1)  n=0
A(m,n)= A(m-1,A(m,n-1))   m,n>0
*/ 
Console.WriteLine("Введите неотрицательное число 1: ");
int numberm = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите неотрицательное число 2: ");
int numbern = Convert.ToInt32(Console.ReadLine());

int Akker(int m, int n)
{
    if (m == 0)     return n+1;
    else if  (m!=0 && n==0) return Akker(m-1,1);
         else   return Akker(m-1,Akker(m,n-1));
}

int result = Akker(numberm, numbern);
Console.WriteLine();
Console.WriteLine(result);