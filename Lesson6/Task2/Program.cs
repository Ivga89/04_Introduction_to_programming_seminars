// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// y = k1 * x + b1, b1 = 2, k1 = 5, 
// y = k2 * x + b2; b2 = 4, k2 = 9
// y = 5 * x + 2
// y = 9 * x + 4
// y = 5x + 2
// y = 9x + 4
// 0 = -4x - 2; 4x = -2; x = 0,5

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

double Equation (double b1, double k1, double b2, double k2, double x) {
    double y = (k1 * x + b1) - (k2 * x + b2);
    return y;
}




System.Console.WriteLine("To fond the point of intersection of two lines");
double b1 = Prompt("Enter b1: ");
double k1 = Prompt("Enter k1: ");
double b2 = Prompt("Enter b2: ");
double k2 = Prompt("Enter k2: ");
double x = 0.5f;
double y = Equation(b1, k1, b2, k2, x);
System.Console.WriteLine($"Intersection point: ({x}; {y})");