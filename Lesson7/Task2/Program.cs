// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
        System.Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

bool IsExist(int[,] array, int m, int n)
{
    if (m > 0 & m < array.GetLength(0) + 1)
    {
        if (n > 0 & n < array.GetLength(1) + 1)
        {
            return true;
        }
    }
    return false;
}

int[,] array = new int[5, 3];
PrintArray(FillArray(array));
int row = Prompt("Enter vertical position: ");
int column = Prompt("Enter horizontal position: ");
if (IsExist(array, row, column)) System.Console.WriteLine($"Element: {array[row - 1, column - 1]}");
if (!IsExist(array, row, column)) System.Console.WriteLine($"Element doesn't exist");

