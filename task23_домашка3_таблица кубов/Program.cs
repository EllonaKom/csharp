/* Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) и выводит таблицу кубов чисел
 от 1 до N (включительно) каждое на новой строке.

N = 3 

1
8
27
*/

System.Console.Write("Введи число: ");
int userNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= userNumber; i++)
{
   System.Console.WriteLine(Math.Pow(i,3));
   // System.Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i,3)}");
}