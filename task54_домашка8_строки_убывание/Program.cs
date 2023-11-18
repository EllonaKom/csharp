/*Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/ 

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


    void SortRowsDescending(int[,] matrix)
    {
        int j = 0;
        int k = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)               
        {
            for (j = 0; j < matrix.GetLength(1); j++)                
            {
                int max = j;
                for (k = j; k < matrix.GetLength(1); k++)            
                {
                    if (matrix[i, max] < matrix[i, k])                                                                  
                    {
                        max = k;
                    }
                }
                var temp = matrix[i, max];                     
                matrix[i, max] = matrix[i, j];
                matrix[i, j] = temp;
            }
        }
    }

int[,] array2D = new int[4, 4];
FillArray(array2D);
Print2DArray(array2D);
SortRowsDescending(array2D);
Console.WriteLine();
Print2DArray(array2D);