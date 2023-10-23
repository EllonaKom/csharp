/*Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 12 10
*/

/*int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");// [5, 7, 1, 4

    }

    System.Console.Write("]");
}

int[] ProductArray(int[] arr)                // метод для перемножения пар чисел в одномерном массиве 
                                // и передачи результатов перемножения в новый массив
{
    int size=0;                                
    if (arr.Length%2==1) size=arr.Length/2+1;            // условие, при котором если в исходном массиве нечетное число элементов, 
    else size=arr.Length/2;                    // чтобы при перемножении пар элементов, начиная с концов массива создать иллюзию
                                    // перемножения центрального элемента самого на себя
    int[] res = new int[size];                    // создание нового массива, куда будут записаны результаты перемножения
    for (int i = 0; i < size; i++)    
    {
        if ((arr.Length%2==1)&&(i==size-1)) res[i]=arr[i];    // условие, при котором при нечетном количестве элементов исходного массива 
        else res[i] = arr[i]*arr[arr.Length-i-1];        // средний его элемент будет приравнен к последнему элементу нового массива
    }
    return res;
}
int[] userArray = GetRandomArray(7);
PrintArray(userArray);
System.Console.WriteLine();
int[] newArray = ProductArray(userArray);
PrintArray(newArray);*/

int[] CreateArray(int size, int min, int max)
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

int[] MultArray(int[] array) //[6 7 1 5 6 2 3 8] -> 48 21 2 30
{
    int[] result = new int[array.Length - array.Length / 2];
    int temp = 0;
    for (int i = 0; i < array.Length - array.Length / 2; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
            break; //заканчивает цикл
        }
        temp = array[i] array[array.Length - 1 - i]; // первый элемент массива умножается на последний элемент и далее
        result[i] = temp;
    }
    return result;
}

int[] array = CreateArray(5, 1, 5);
Output(array);
System.Console.WriteLine();
int[] array2 = MultArray(array);
Output(array2);
