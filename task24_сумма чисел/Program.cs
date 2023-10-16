/*24: Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
/*Console.Clear();

int usera = 4;

int Num(int a)
{
    int result = a + a;
    return result;
}
void Num1(int a)
{
    double result = Math.Pow(a, 2);
    System.Console.WriteLine(result);
}

double userresult = Num(usera);
System.Console.WriteLine(userresult);

Num1(usera); */

/*
Console.Clear();
int usera = 7;
int Num(int usera)
{
    int result = 0;
    for ( int i = 0; i <= usera; i ++ )
    {
    result = result + i;
    }
    return result;
}
 int userresult = Num( usera);
      System.Console.WriteLine(userresult);
*/

Console.Clear();
System.Console.Write("Введите число A: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int a)
{
    int summ = 0;

    for (int i = 1; i <= a; i++)
    {
        summ = summ + i;
    }
    return summ;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);





