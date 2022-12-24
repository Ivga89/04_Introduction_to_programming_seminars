// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. Реализовать через функции.

double Prompt (string message) {
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

double Exponantiation (double a, double b) {
    return Math.Pow(a, b);
}

double a = Prompt("Enter a number for exponantiation: ");
double b = Prompt("Enter a degree: ");
double exp = Exponantiation(a, b);

System.Console.WriteLine($"Number {a} in degree {b} is equal {exp}.");