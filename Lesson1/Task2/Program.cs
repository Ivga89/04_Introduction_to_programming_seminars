// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int Prompt(string message) {
    System.Console.WriteLine($"{message} > ");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int n1 = Prompt("Enter the first number: ");
int n2 = Prompt("Enter the second number: ");
int n3 = Prompt("Enter the third number: ");
int max = n1;

if (max < n2) max = n2;
if (max < n3) max = n3;

System.Console.WriteLine($"The biggest number is {max}.");