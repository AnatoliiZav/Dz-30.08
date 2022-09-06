// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue + 1);

    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

int[] SortArray(int[,] inArray)   // создаем одномерный массив из сумм строк двумерного
{
    int[] newArray = new int[inArray.GetLength(0)];
    int index = 0;
    int sum =0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {    for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i,j];
        }
        newArray[index] = sum;
        index++;
        sum=0;
    }
    return newArray;
}

void PrintArray1(int[] arr) // печать одномерного массива, для наглядности
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int NumStringArray(int[] mas)
{
    int min = mas[0];
    int num = 0;
    for (int i = 1; i < mas.Length; i++)
    {
        if (min > mas[i])
        {
            min = mas[i];
            num =i;
        }
        
    }
    return num +1;
}

Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(a, b, 0, 10);
PrintArray(myArray);
Console.WriteLine();

int[] arr = SortArray(myArray);
PrintArray1(arr);
Console.WriteLine();
Console.WriteLine($"номер строки с наименьшей суммой элементов:{NumStringArray(arr)} строка");
