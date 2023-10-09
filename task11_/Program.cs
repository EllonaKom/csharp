/*11. Напишите программу, которая выводит случайное трёхзна
чное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/
int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;

System.Console.WriteLine("число " + first + last);
//int result = firstNumber * 10 + threeNumber;
// выводим 