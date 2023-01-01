// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] RandomArray (int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 100);
        System.Console.Write($"{array[i]} ");
    } return array;
}

int SumOfOddElements(int[] array) {
    int sum = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            sum = sum + array[i];
        }
    } return sum;
}

int randomElemOfArray = new Random().Next(5, 16);
int[] array = RandomArray(new int[randomElemOfArray]);
int sumOfOddElements = SumOfOddElements(array);
System.Console.WriteLine();
System.Console.WriteLine($"The summ of odd elements of array is: {sumOfOddElements}");
