// Напишите программу, которая будет выводить выводить  все целые числа от - до числа
System.Console.WriteLine("Введите число:");
//int number1 = int.Parse(Console.ReadLine());
int number1 = Convert.ToInt32(Console.ReadLine());

for (int i = number1 * -1; i < number1 + 1; i++)

   System.Console.Write(i + " ");
