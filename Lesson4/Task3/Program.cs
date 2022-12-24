// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). Реализовать через функции. 
// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”, 
// “Введите максимальный порог случайных значений”)

int Prompt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}




int countOfArrayElements = Prompt("Enter the count of elements of array");
int min = Prompt("Enter the min of values");
int max = Prompt("Enter the max of values");
int[] array = new int[countOfArrayElements];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        System.Console.Write($"{array[i]} ");
    }