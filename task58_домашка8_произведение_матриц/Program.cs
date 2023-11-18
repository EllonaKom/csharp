/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.
*/ 

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
 int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {
        int[,] multiplicative = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
        for (int i = 0; i < multiplicative.GetLength(0); i++)
        {
            for (int j = 0; j < multiplicative.GetLength(1); j++)
            {
                for (int k = 0; k < matrixA.GetLength(1); k++)
                {
                    multiplicative[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }
        return multiplicative;
    }

    int[,] array2D = new int[4, 4];
FillArray(array2D);
Print2DArray(array2D);
Console.WriteLine();
int[,] array3D = new int[4, 4];
FillArray(array3D);
Print2DArray(array3D);
int[,] arraySum =MatrixMultiplication(array2D,array3D);
Console.WriteLine();
Print2DArray(arraySum);