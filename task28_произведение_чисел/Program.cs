/*28: Напишите программу, которая
принимает на вход число N и выдаёт
произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/ 

/*System.Console.Write("Введите число N: ");
int userN = Convert.ToInt32(Console.ReadLine());

int Number(int n)
{
    int num = 1;

    for (int i = 1; i <= n;  i++)
    {
         num = num * i;
    }
    return num;
}
int userResult = Number(userN);
System.Console.WriteLine(userResult);*/

Console.Clear();
System.Console.Write("Введите число N: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Summer(int a)
{
    int summ = 1;

    for (int i = 1; i <= a; i++)
    {
        summ = summ*i;
    }
    return summ;
}
int userResult = Summer(userA);
System.Console.WriteLine(userResult);