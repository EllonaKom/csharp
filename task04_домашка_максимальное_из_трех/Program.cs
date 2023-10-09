/* 2. Внутри класса Answer напишите метод FindMax, который принимает на вход три числа 
и выдаёт максимальное из этих чисел. */

System.Console.WriteLine("Введите число 1");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 3");
int userNumber3 = Convert.ToInt32(Console.ReadLine());

int max = userNumber1;
if (userNumber2 > max)
{
    max = userNumber2;
}
if (userNumber3 > max)
{
    max = userNumber3;
}

System.Console.WriteLine($"Максимальное число  {max} ");
return max;