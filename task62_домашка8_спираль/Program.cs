/*Задача 62: Заполните спирально массив 4 на 4.
*/ 
Console.Clear();

void FillArraySpir(int[,] arr)
{
    int sum = 0;
    int j = 0;
    
  
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if ((i) % 2 ==0)
        {
        for ( j = 0; j < arr.GetLength(1); j++)
        {
            sum++;
            arr[i, j] = sum ;
        }
        }
        else
        {
        for ( j = (arr.GetLength(1)-1); j >= 0; j--)
        {
            sum++;
            arr[i, j] = sum ;
        }
       }

    }
    }



void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArray_(int[] array)
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
    


int[,] array2D = new int[4, 4];

FillArraySpir(array2D);
Print2DArray(array2D);

