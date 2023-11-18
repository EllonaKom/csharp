/*63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.*/ 

/*class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Натуральные числа от 1 до {n}:");
        for (int i = 1; i <= n; i++)
        {
            Console.Write(i + " ");
        }

        Console.ReadLine(); 
    }
}*/
Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void IntN(int number, int current = 1)
{    
    if (number < current) return;
    else
    {
    Console.Write(current + " ");
    IntN(number, current + 1);
    }
}

IntN(number);