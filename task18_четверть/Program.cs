/*18: Напишите программу, которая по
заданному номеру четверти, показывает
диапазон возможных координат точек в этой
четверти (x и y).
*/

System.Console.WriteLine("Введите номер четверти плоскости от 1 до 4: ");
int userN = Convert.ToInt32(Console.ReadLine());

if (userN == 1)
{
    System.Console.WriteLine("Для 1 четверти -  X больше 0,  Y больше 0");
}
if (userN == 2)
{
    System.Console.WriteLine("Для 2 четверти -  X меньше 0,  Y больше 0");
}
if (userN == 3)
{
    System.Console.WriteLine("Для 3 четверти -  X меньше 0,  Y меньше 0");
}
if (userN == 4)
{
    System.Console.WriteLine("Для 4 четверти -  X больше 0,  Y меньше 0");
}
if (userN < 1 || userN > 4)
{
    System.Console.WriteLine("Номер четверти плоскости введен неверно");
}