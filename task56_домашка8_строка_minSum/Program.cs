/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.*/ 
Console.Clear();

void FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
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
     int SumOfRow(int[,] matrix, int row)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[row, j];
        }
        return sum;
    }

    int[] MinimumSumRow(int[,] matrix)
    {
        int[] RowNumberAndSum = new int[2];
        RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (RowNumberAndSum[1] > SumOfRow(matrix, i))
            {
                RowNumberAndSum[0] = i;
                RowNumberAndSum[1] = SumOfRow(matrix, RowNumberAndSum[0]);
            }
        }
        return RowNumberAndSum;
    }

int[,] array2D = new int[4, 5];
FillArray(array2D);
Print2DArray(array2D);
 int[] arrayD = MinimumSumRow(array2D);
Console.WriteLine();
PrintArray_(arrayD);