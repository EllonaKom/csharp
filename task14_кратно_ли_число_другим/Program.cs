/*14. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да*/ 

System.Console.WriteLine("Введите число 1");
int userNumber1 = Convert.ToInt32(Console.ReadLine());



if (userNumber1 % 7 == 0 && userNumber1 % 23 == 0 )
{
    System.Console.WriteLine("Кратно ");
}
else
{
    System.Console.WriteLine("Некратно " );
}

