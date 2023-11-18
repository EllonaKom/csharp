/*Задача 61: Вывести первые N строк треугольника
Паскаля. Сделать вывод в виде равнобедренного
треугольника*/

Console.Clear();


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int Factorial(int n)
{
    int x = 1;
    for (int i = 0; i <= n; i++)
    {
        x *= i;
    }
    return x;
}



void Nuton(int nn)
{
    int cc=1;
    for (int i = 0; i <= nn; i++)
    {


        for (int j = 1; j <= nn - i; j++)    //отступ от левой стороны

            Console.Write(" ");
        for (int k = 0; k < i; k++)
        {
            if (k == 0 || i == 0)
                cc = 1;
            else

                cc = cc * (i - k + 1) / k;
            Console.Write("{0}   ", cc);
        }
        Console.Write("\n");
    }
}


int str = TakeEnteredNumber("Введите количестов строк треугольника Паскаля:");

Nuton(str);
