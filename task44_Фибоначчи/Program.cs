/*З адача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

System.Console.WriteLine("Задай число");
int num = Convert.ToInt32(Console.ReadLine());

string Fibon(int a)
{
    string result = "";
    int pred = 0;


    for (int i = 0; i < a; i++)
    {
        if (i == 0) result = "0";
        if (i == 1) result = "01";
        if (i > 1)
        {
            pred = i + i - 3;
        result = result +pred;
            System.Console.WriteLine(" " + result);
        }
    }
    return result;
}
//Fibon(num);
System.Console.WriteLine(Fibon(num));


