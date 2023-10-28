/*Задача 45: Напишите программу, которая будет создавать копию
заданного массива с помощью поэлементного копирования.*/ 

int Prompt(string massage)
{
    System.Console.Write(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}
int [] CopyArray(int[] arr)
{
   int[] arrCopy = new int[arr.Length];
   for (int i = 0; i < arr.Length; i++)
    {
        arrCopy[i] = arr[i];
    }
    return arrCopy;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.WriteLine("]  ");
    
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значене для дапазона случайного числа: ");
int[] array = GenerateArray(length, min, max);
System.Console.WriteLine("Заданный массив: ");
PrintArray(array);
int [] array1 = CopyArray(array);
System.Console.WriteLine("Полученный массив массив: ");
PrintArray(array1);