// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Не использовать строки

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine($"Enter a three-digit number: ");  //число один раз требуется, поэтому не стала использовать функцию/метод
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000) {  //проверяем трехзначное ли число
    int div = n / 10;
    int rem = div % 10;
    System.Console.WriteLine($"The second digit of number {n} is {rem}.");
}
else {
    System.Console.WriteLine("You entered not a three-digit number.");
}