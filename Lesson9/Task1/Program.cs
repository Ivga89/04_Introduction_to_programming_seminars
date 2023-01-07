// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"


void PrintEvenNumbers(int m, int n) {
    if (n <= m) {
        return;
    }
    if (n % 2 == 1) {
        n--;
    }
    PrintEvenNumbers(m, n - 1);
    System.Console.Write($"{n} ");
}

PrintEvenNumbers(1, 5);
System.Console.WriteLine();
PrintEvenNumbers(4, 8);