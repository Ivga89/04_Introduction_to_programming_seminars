// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int n = Prompt("Enter a number");

for (int i = 1; i <= n; i++) {
    System.Console.Write($"{i * i * i} ");
}