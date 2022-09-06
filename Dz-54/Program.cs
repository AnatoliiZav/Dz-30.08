// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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




void SortArray(int[,] inArray)   // метод сортировки пузырька, для двумерного массива, от большего к меньшему в каждой строке
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int m = j + 1; m < inArray.GetLength(1); m++)
            {
                if (inArray[i, j] < inArray[i, m])
                {
                    int k = inArray[i, j];
                    inArray[i, j] = inArray[i, m];
                    inArray[i, m] = k;
                }
            }
        }
    }
}


Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(a, b, 0, 10);
PrintArray(myArray);
Console.WriteLine();
SortArray(myArray);
PrintArray(myArray);




