// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GetArray(int m, int n, int o, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, o];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < o; k++)
            {


                {
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1);

                }



            }
    return result;

}





void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }

            Console.WriteLine();
        }

    }

}



Console.Write("a= ");
int a = int.Parse(Console.ReadLine());
Console.Write("b= ");
int b = int.Parse(Console.ReadLine());
Console.Write("c= ");
int c = int.Parse(Console.ReadLine());

int[,,] myArray = GetArray(a, b, c, 0, 10);
PrintArray(myArray);


