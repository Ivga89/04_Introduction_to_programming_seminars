// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray(int[] array) {
    System.Console.WriteLine("Our array: ");
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000);
        System.Console.Write($"{array[i]} ");
    } return array;
}

int Even(int[] array) {
    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count ++;
        }
    } return count;
}

int countOfArrayElements = new Random().Next(5, 16);
int[] array = RandomArray(new int[countOfArrayElements]);
int evenCount = Even(array);
System.Console.WriteLine();
System.Console.WriteLine($"The count of even elements in array is: {evenCount}");