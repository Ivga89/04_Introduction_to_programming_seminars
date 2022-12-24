// Задача 2: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе. Реализовать через функции.

int Prompt (string message) {
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits (int a) {
    int sum = 0;
    while (a > 0) {
        sum = sum + (a % 10);
        a = a / 10;
    }
    return sum;
}

int a = Prompt("Enter number: ");
int sum = SumOfDigits(a);
System.Console.WriteLine($"The sum of digits in number {a} is equal to {sum}");