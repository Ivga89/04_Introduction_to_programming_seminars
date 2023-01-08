// Задача 1: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
        System.Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

int[,] SortDecsending(int[,] matrix)
{
    int count = 200; //немного преувеличино, но это едиственный способ до которого я додумалась
    while (count > 0)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    (matrix[i, j], matrix[i, j + 1]) = (matrix[i, j + 1], matrix[i, j]);

                }
            }
        }
        count--;
    }
    return matrix;
}

int[,] matrix = new int[6, 6];
PrintMatrix(FillMatrix(matrix));
System.Console.WriteLine();
PrintMatrix(SortDecsending(matrix));
