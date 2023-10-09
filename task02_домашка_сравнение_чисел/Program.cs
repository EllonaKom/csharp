/* 1.Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и 
выводит, какое число большее, а какое меньшее. */

System.Console.WriteLine("Введите число 1");

int userNumber1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 )
{
     System.Console.WriteLine($"Введенные числа равны   {userNumber1}  ");
}
if  (userNumber1 > userNumber2 )
{
      System.Console.WriteLine($"Первое число  {userNumber1} больше, чем второе число  {userNumber2} ");
}
if  (userNumber1 < userNumber2 )
{
      System.Console.WriteLine($"Первое число  {userNumber1} меньше, чем второе число  {userNumber2} ");
}