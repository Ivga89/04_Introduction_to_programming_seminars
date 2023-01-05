// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillMatrix(int[,] matrix)     // инициализация двумерного массива
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

void PrintMatrix(int[,] matrix)      // вывод двумерного массива
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

int[] Sum(int[,] matrix)             // вычисляет сумму каждой строки двумерного массива
{
    int[] arraySum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j]; // сумма каждой строки
            arraySum[i] = sum;        // и ее присвоение элементу нового массива
        }

    }
    return arraySum;
}

(int,int) MinSum(int[] array) {      // поиск минимального из всех сумм и строка
    int min = 999;                   // формальность, программа не предполагает большего числа
    int minRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) {
            min = array[i];
            minRow = i + 1;
        }
    } return (min, minRow);
}

// код программы             
int[,] matrix = new int[6, 3];       // создание двумерного массива
PrintMatrix(FillMatrix(matrix));     // вывод

System.Console.WriteLine();
int[] sumsOfRows = Sum(matrix);      // суммы строк

(int minValeuOfSums, int minValue) = MinSum(sumsOfRows); // минимальное среди сумм и строка
System.Console.WriteLine($"Минимальное значение суммы находится в {minValue} строке и равно {minValeuOfSums}");
