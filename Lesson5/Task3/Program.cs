// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] RandomDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
        System.Console.Write($"{array[i]:F3} ");
    }
    return array;
}

double Max(double[] array)
{
    double max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

    }
    return max;
}

double Min(double[] array)
{
    double min = 100;

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}




double[] array = RandomDoubleArray(new double[10]);
double minValue = Min(array);
double maxValue = Max(array);
System.Console.WriteLine();
System.Console.WriteLine($"The difference between maximum ({maxValue:F3}) and minimum ({minValue:F3}) number is: {(maxValue - minValue):F3}");