/* Внутри класса Answer напишите метод CheckIfEven, который на вход 
принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).*/ 

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = userNumber % 2;

if  (result == 0 )
{ 
      System.Console.WriteLine($"Число  {userNumber} четное ");
}
else
{
      System.Console.WriteLine($"Число  {userNumber} нечетное ");
 }