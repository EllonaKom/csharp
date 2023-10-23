/*Задача 33: Задайте массив. Напишите программу, которая
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/ 
/*Console.Clear();
int[] GetRandArray(int start, int end, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i]= new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if(i < arr.Length -1)
        System.Console.Write(", ");
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

System.Console.WriteLine("Ввести размер массива: ");
int userSize = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввести диапазон массива от: ");
int userStart = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ввести диапазон массива до: ");
int userEnd = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandArray(userStart, userEnd, userSize);
PrintArray(userArray);
System.Console.WriteLine("Какое число ищем?");
int userNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(findNum(userArray,userNum));*/

/*int[] CreateArray(int size, int min, int max)
{
    var random = new Random();

    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}

void Output(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

// void IsBelong(int[] arr, int number)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == number)
//         System.Console.WriteLine($"Число {number} есть в массиве");
//         // else if(arr[i]!= number)
//         // System.Console.WriteLine($"Числа {number} нет в массиве");
//     }
// }

bool IsBelong(int[] arr, int number)
{
    bool result = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == number)
            result = true;
    }
    return result;
}

int[] arr = CreateArray(4, -21, 10);
Output(arr);

System.Console.WriteLine("Введите число: ");

int n = int.Parse(Console.ReadLine());
// IsBelong(arr, n);

// System.Console.WriteLine(IsBelong(arr, n));
bool result2 = IsBelong(arr,n);
System.Console.WriteLine((result2)?$"Число {n} в массиве есть":"Числа {n} в массиве нет");*/

int Prompt(string message)
{
    System.Console.Write(message);
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


bool findNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(num == array[i])
        return true;
    }
    return false;
}

void PrintArray(int[] arrayOne, bool a)
{
    System.Console.WriteLine();
    System.Console.Write("[");
    for (int i = 0; i < arrayOne.Length; i++)
    {
        System.Console.Write(arrayOne[i]);
        if (i < arrayOne.Length - 1)
            System.Console.Write(", ");
    }
    System.Console.Write("] -> ");
    if (a == true) System.Console.WriteLine("Да");
    else System.Console.WriteLine("Нет");
}

int length = Prompt("Длина массива: ");
int min = Prompt("Начальное значение для диапазона случайного числа: ");
int max = Prompt("Конечное значение для дапазона случайного числа: ");
int num = Prompt("Проверка числа в массиве: ");
int[] array = GenerateArray(length, min, max);
PrintArray(array, findNum(array, num));





