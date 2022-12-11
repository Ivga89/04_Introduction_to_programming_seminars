// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int Prompt(string message)
{
    System.Console.WriteLine($"{message} >");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int n1 = Prompt("Enter the first number: ");
int n2 = Prompt("Enter the second number: ");

if (n1 > n2)
{
    System.Console.WriteLine($"The first number ({n1}) is bigger than the second ({n2})");
}

else
{
    System.Console.WriteLine($"The second number ({n2}) is bigger than the first ({n1})");
}