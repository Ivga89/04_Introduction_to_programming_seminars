// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 1 | 3 4
// 3 2 1 | 3 3
// _ _ _ | 1 1
// Результирующая матрица будет:
// 19 21
// 16 19

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

int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)     // произведение двух матриц
{
    int[,] matrixProduct = new int[matrix1.GetLength(0), matrix1.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            matrixProduct[i, j] = 0;
            for (int k = 0; k < matrix2.GetLength(0); k++) 
            {
                matrixProduct[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixProduct;
}

int[,] matrix1 = new int[2, 3] {{2, 4, 1},             // для наглядности работоспособности
                                {3, 2, 1}};            // взяла матрицу с примера
int[,] matrix2 = new int[3, 2]  {{3, 4},
                                 {3, 3},
                                 {1, 1}}; 

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();
System.Console.WriteLine("Произведение матриц: ");
PrintMatrix(MatrixProduct(matrix1, matrix2));