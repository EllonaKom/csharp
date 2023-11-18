/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.
*/



void GetRandom3DArray(int[,,] array)
{
    int znac = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = znac;
                znac++;
            }
        }
    }

}

void Print3DArray(int[,,] array)
{
    
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"[" + i + "]");
                System.Console.Write($"[" + j + "]");
                System.Console.Write($"[" + k + "] ");
                System.Console.Write(array[i, j, k] + "  ");
            }

        }
    }
}
System.Console.WriteLine();


int[,,] user3DArray = new int[3, 3, 3];

GetRandom3DArray(user3DArray);

Print3DArray(user3DArray);