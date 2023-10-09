/*2.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5 -> некратно, остаток 4
16, 4 -> кратно*/

System.Console.WriteLine("Введите число 1");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

int max = userNumber1;
if (userNumber1 % userNumber2 == 0)
{
    System.Console.WriteLine("Кратно ");
}
else
{
    System.Console.WriteLine("Остаток " + (userNumber1 % userNumber2));
}

