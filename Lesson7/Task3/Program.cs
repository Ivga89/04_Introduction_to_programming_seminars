// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
        System.Console.WriteLine();
    }
    return array;
}

void PrintArray2(int[,] array)
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

void PrintArray1(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{Math.Round(array[i], 2)}\t");
    }
}

double[] Average(int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0.0f;
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
            count++;
        } 
        newArray[i] = sum / count;
    }
    
    return newArray;
}

int[,] array2 = new int[2, 3];
PrintArray2(FillArray(array2));
System.Console.WriteLine();
double[] array1 = Average(array2);
PrintArray1(array1);
