// Задача *: Напишите программу, которая из массива случайных чисел. Ищет второй максимум
//  (число меньше максимального элемента, но больше всех остальных). Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

int[] RandomArray(int[] array)
{
    System.Console.WriteLine("Our array: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 101);
        System.Console.Write($"{array[i]} ");
    }
    return array;
}

int SearchPreMax(int[] array)
{
    int max = 0, premax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
        if (premax < array[i] && array[i] < max)
        {
            premax = array[i];
        }
    }
    return premax;
}


int random = new Random().Next(10, 21);
int[] array = RandomArray(new int[random]);
int premaxValue = SearchPreMax(array);
System.Console.WriteLine();
System.Console.WriteLine($"premaximum number is: {premaxValue}");


